using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class Transaction_History : Form
    {
        private int hesapID;
        int satirIndex = 0;
        int sayfaNo = 1;
        public Transaction_History()
        {
            InitializeComponent();
            DataTable dataTable = new DataTable();
            Connection.conn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT islem_turu, tutar, tarih, aciklama FROM Islemler", Connection.conn);
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            Connection.conn.Close();
        }

        public Transaction_History(int hesapID)
        {
            this.hesapID = hesapID;
            InitializeComponent();
            List_Account_Transactions();
        }

        private void List_Account_Transactions()
        {
            try
            {

                DataTable dataTable = new DataTable();
                Connection.conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT islem_turu, tutar, tarih, aciklama FROM Islemler WHERE hesapID = @hesapID", Connection.conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@hesapID", hesapID);
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                Connection.conn.Close();
            }
            catch (Exception ex)
            {
                Connection.conn.Close();
                MessageBox.Show("Hata : " + ex.Message);
            }
        }


        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem != null)
            {
                string islemTuru = dataGridView1.Rows[e.RowIndex].Cells["islem_turu"].Value.ToString();

                if (islemTuru == "Yatırma")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (islemTuru == "Çekme")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
                else if (islemTuru == "Havale")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightBlue;
                }
            }
        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            DateTime baslangic = dateTime_baslangic.Value.Date;
            DateTime bitis = dateTime_bitis.Value.Date;

            string filtre = $"tarih >= '#{baslangic:dd/MM/yyyy}#' AND tarih <= '#{bitis:dd/MM/yyyy}#'";

            try
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = filtre;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filtreleme hatası: " + ex.Message);
            }

        }

        private void Print_Button_Click(object sender, EventArgs e)
        {

            satirIndex = 0;
            sayfaNo = 1;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Ayarlar
            int hucreGenisligi = 140;
            int satirYuksekligi = 30;
            int toplamGenislik = dataGridView1.Columns.Count * hucreGenisligi;
            int solMargin = e.MarginBounds.Left + (e.MarginBounds.Width - toplamGenislik) / 2;
            int y = 110; // tablo başlangıcı

            // Fontlar
            Font baslikFontu = new Font("Segoe UI", 12, FontStyle.Bold);
            Font yaziFontu = new Font("Segoe UI", 10);
            Font bankFont = new Font("Segoe UI", 14, FontStyle.Bold);
            Brush firca = Brushes.Black;
            Pen cerceve = Pens.Black;

            // 📌 Logo ve yazı hizalama
            string logoPath = @"C:\Users\ASUS\Desktop\MyProjects\BankApp\BankApp\RensBank_logo.PNG";
            int logoY = 30;
            int logoHeight = 50;
            int logoWidth = 80;
            int logoX = e.MarginBounds.Left;

            if (File.Exists(logoPath))
            {
                Image logo = Image.FromFile(logoPath);
                e.Graphics.DrawImage(logo, new Rectangle(logoX, logoY, logoWidth, logoHeight));

                // Banka adı logonun hizasında, sağında yer alacak
                e.Graphics.DrawString("Rens Bank", bankFont, firca, logoX + logoWidth + 10, logoY + 10);
            }

            // 📌 Başlık ve tarih (sağ üst)
            string baslik = "İşlem Geçmişi Çıktısı";
            string tarih = $"Tarih: {DateTime.Now:dd.MM.yyyy HH:mm}";

            SizeF baslikBoyutu = e.Graphics.MeasureString(baslik, baslikFontu);
            SizeF tarihBoyutu = e.Graphics.MeasureString(tarih, yaziFontu);

            int baslikX = e.MarginBounds.Right - (int)baslikBoyutu.Width;
            int tarihX = e.MarginBounds.Right - (int)tarihBoyutu.Width;
            int baslikY = logoY + 5;
            int tarihY = logoY + 30;

            e.Graphics.DrawString(baslik, baslikFontu, firca, baslikX, baslikY);
            e.Graphics.DrawString(tarih, yaziFontu, firca, tarihX, tarihY);

            // 🔹 Tablo Başlıkları
            y = logoY + logoHeight + 30; // tablo başı, logodan sonra

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Rectangle rect = new Rectangle(solMargin + i * hucreGenisligi, y, hucreGenisligi, satirYuksekligi);
                e.Graphics.FillRectangle(Brushes.LightGray, rect);
                e.Graphics.DrawRectangle(cerceve, rect);
                e.Graphics.DrawString(dataGridView1.Columns[i].HeaderText, yaziFontu, firca, rect.X + 5, rect.Y + 5);
            }

            y += satirYuksekligi;

            // 🔹 Tablo Satırları
            while (satirIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[satirIndex];
                if (!row.IsNewRow)
                {
                    string islemTuru = row.Cells["islem_turu"].Value?.ToString()?.ToLower() ?? "";  // Kolon adın buysa

                    // 2️⃣ Renge göre fırça belirle
                    Brush arkaPlanFircasi = Brushes.White;

                    if (islemTuru.Contains("yatırma"))
                        arkaPlanFircasi = Brushes.LightGreen;
                    else if (islemTuru.Contains("çekme"))
                        arkaPlanFircasi = Brushes.LightCoral;
                    else if (islemTuru.Contains("havale"))
                        arkaPlanFircasi = Brushes.LightBlue;
                    else if (islemTuru.Contains("havale"))
                        arkaPlanFircasi = Brushes.Orange;

                    // 3️⃣ Hücreleri çiz
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        Rectangle rect = new Rectangle(solMargin + i * hucreGenisligi, y, hucreGenisligi, satirYuksekligi);
                        e.Graphics.FillRectangle(arkaPlanFircasi, rect); // Arka plan
                        e.Graphics.DrawRectangle(cerceve, rect);

                        string hucreDegeri = row.Cells[i].Value?.ToString() ?? "";
                        e.Graphics.DrawString(hucreDegeri, yaziFontu, firca, rect.X + 5, rect.Y + 5);
                    }

                    y += satirYuksekligi;
                }

                satirIndex++;

                if (y + satirYuksekligi > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
            satirIndex = 0;

        }

        private void Button_onlyRemittence_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable dt = dataGridView1.DataSource as DataTable;
                if (dt != null)
                {
                    dt.DefaultView.RowFilter = "islem_turu LIKE '%Havale%'";
                }
                else
                {
                    MessageBox.Show("Veri kaynağı DataTable değil.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filtreleme hatası: " + ex.Message);
            }
        }

        private void Button_onlyWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = dataGridView1.DataSource as DataTable;
                if (dt != null)
                {
                    dt.DefaultView.RowFilter = "islem_turu LIKE '%Yatırma%'";
                }
                else
                {
                    MessageBox.Show("Veri kaynağı DataTable değil.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filtreleme hatası: " + ex.Message);
            }
        }

        private void Button_onlyDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = dataGridView1.DataSource as DataTable;
                if (dt != null)
                {
                    dt.DefaultView.RowFilter = "islem_turu LIKE '%Çekme%'";
                }
                else
                {
                    MessageBox.Show("Veri kaynağı DataTable değil.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filtreleme hatası: " + ex.Message);
            }
        }

        private void Button_showAll_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = dataGridView1.DataSource as DataTable;
                if (dt != null)
                {
                    dt.DefaultView.RowFilter = ""; // tüm satırlar gösterilir
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filtre temizleme hatası: " + ex.Message);
            }
        }
    }
}
