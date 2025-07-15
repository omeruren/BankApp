using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class ListAccounts : Form
    {
        private int satirIndex;
        private int sayfaNo;

        public ListAccounts()
        {
            InitializeComponent();
        }

        private void ListAccounts_Load(object sender, EventArgs e)
        {
            ListTheAccounts();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Ad Soyad";
            dataGridView1.Columns[2].HeaderText = "Hesap Numarası";
            dataGridView1.Columns[3].HeaderText = "Bakiye";
            dataGridView1.Columns[4].HeaderText = "Açılış Tarihi";

        }

        private void ListTheAccounts()
        {
            DataTable dataTable = new DataTable();
            Connection.conn.Open();
            SqlDataAdapter sqlCommand = new SqlDataAdapter("SELECT H.hesapID, U.ad_soyad, H.hesap_no, H.bakiye, H.acilis_tarihi FROM Hesaplar H INNER JOIN Kullanicilar U ON H.kullaniciID = U.kullaniciID;", Connection.conn);

            sqlCommand.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            Connection.conn.Close();

        }

        private void UpdateAccount_Button_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            Name_Text.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            AccNo_Text.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Balance_text.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            CreateDate_text.Text = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value.ToString()).ToString();
        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen bir hesap seçiniz.");
                    return;
                }
                foreach (Control item in groupBox1.Controls)
                {

                    if (item is TextBox && item.Text == "")
                    {
                        Result_Label.ForeColor = Color.Red;
                        Result_Label.Text = "Boş alan bırakamazsınız.";
                        return;
                    }
                }

                if (AccNo_Text.Text.Count() != 20)
                {
                    Result_Label.ForeColor = Color.Red;
                    Result_Label.Text = "Hesap Numarası 20 haneli olmak zorundadır";
                    return;
                }

                if (Convert.ToDecimal(Balance_text.Text) < 0)
                {
                    Result_Label.ForeColor = Color.Red;
                    Result_Label.Text = "bakiye 0'dan  küçük olamaz.";
                    return;
                }



                Connection.conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Hesaplar SET" +
                    " hesap_no = @hesapno, bakiye = @bakiye WHERE hesapID = @id", Connection.conn);

                cmd.Parameters.AddWithValue("hesapno", AccNo_Text.Text.Trim());
                cmd.Parameters.AddWithValue("bakiye", Convert.ToDecimal(Balance_text.Text.Trim()));
                cmd.Parameters.AddWithValue("id", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));


                cmd.ExecuteNonQuery();
                Connection.conn.Close();
                Result_Label.ForeColor = Color.Green;
                Result_Label.Text = "Hesap başarıyla güncellendi";
                ListTheAccounts();
            }
            catch (Exception ex)
            {
                Connection.conn.Close();
                MessageBox.Show("Hata : " + ex.Message);
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void DeleteAccount_Button_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen bir hesap seçiniz.");
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Bu hesap slinecek. Onaylıyor musunuz ?", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {


                Connection.conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Hesaplar WHERE hesapID = @id", Connection.conn);
                cmd.Parameters.AddWithValue("id", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

                cmd.ExecuteNonQuery();
                Result_Label.ForeColor = Color.Green;
                Result_Label.Text = "Hesap başarıyla silindi";
                Connection.conn.Close();
                ListTheAccounts();
                }

            }
            catch (Exception ex)
            {
                Connection.conn.Close();
                MessageBox.Show("Hata : " + ex.Message);
            }
        }

        private void UserSearch_Button_Click(object sender, EventArgs e)
        {
            string filter = UserName_text.Text.Trim();
            if (UserName_text.Text.Trim() == "")
            {
                Result_Label.ForeColor = Color.Red;
                Result_Label.Text = "Kullanıcı alanı boş kalamaz.";
            }

            try
            {
                DataTable dt = dataGridView1.DataSource as DataTable;
                if (dt != null)
                {
                    dt.DefaultView.RowFilter = $"ad_soyad LIKE '%{filter}%'";
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

        private void Print_Button_Click(object sender, EventArgs e)
        {
            satirIndex = 0;
            sayfaNo = 1;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font bankFont = new Font("Segoe UI", 14, FontStyle.Bold);
            Font baslikFontu = new Font("Segoe UI", 12, FontStyle.Bold);
            Font yaziFontu = new Font("Segoe UI", 9);
            Brush firca = Brushes.Black;
            Pen cerceve = Pens.Black;


            int sayfaGenisligi = e.MarginBounds.Width;
            int sayfaSol = e.MarginBounds.Left;
            int sayfaSag = e.MarginBounds.Right;

            int satirYuksekligi = 30;
            int logoY = 30;
            int logoHeight = 50;
            int logoWidth = 80;
            int y = 0;

            // 🔹 LOGO + BANKA ADI
            string logoPath = @"C:\Users\ASUS\Desktop\MyProjects\BankApp\BankApp\RensBank_logo.PNG";
            if (File.Exists(logoPath))
            {
                Image logo = Image.FromFile(logoPath);
                e.Graphics.DrawImage(logo, new Rectangle(sayfaSol, logoY, logoWidth, logoHeight));
                e.Graphics.DrawString("Rens Bank", bankFont, firca, sayfaSol + logoWidth + 10, logoY + 10);
            }

            // 🔹 BAŞLIK + TARİH
            string baslik = "Hesaplar Çıktısı";
            string tarih = $"Tarih: {DateTime.Now:dd.MM.yyyy HH:mm}";
            SizeF baslikSize = e.Graphics.MeasureString(baslik, baslikFontu);
            SizeF tarihSize = e.Graphics.MeasureString(tarih, yaziFontu);

            float baslikX = sayfaSag - baslikSize.Width;
            float tarihX = sayfaSag - tarihSize.Width;

            e.Graphics.DrawString(baslik, baslikFontu, firca, baslikX, logoY + 5);
            e.Graphics.DrawString(tarih, yaziFontu, firca, tarihX, logoY + 30);

            // 🔹 Tablo Başlığı Başlangıcı
            y = logoY + logoHeight + 30;

            int columnCount = dataGridView1.Columns.Count;
            int hucreGenisligi = sayfaGenisligi / columnCount;

            // 🔹 Başlık Satırı
            for (int i = 0; i < columnCount; i++)
            {
                Rectangle rect = new Rectangle(sayfaSol + i * hucreGenisligi, y, hucreGenisligi, satirYuksekligi);
                e.Graphics.FillRectangle(Brushes.LightGray, rect);
                e.Graphics.DrawRectangle(cerceve, rect);
                e.Graphics.DrawString(dataGridView1.Columns[i].HeaderText, yaziFontu, firca, rect.X + 5, rect.Y + 7);
            }

            y += satirYuksekligi;

            // 🔹 Veriler
            for (int rowIndex = 0; rowIndex < dataGridView1.Rows.Count; rowIndex++)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                if (row.IsNewRow) continue;

                for (int col = 0; col < columnCount; col++)
                {
                    string hucreDegeri = row.Cells[col].Value?.ToString() ?? "";
                    Rectangle rect = new Rectangle(sayfaSol + col * hucreGenisligi, y, hucreGenisligi, satirYuksekligi);
                    e.Graphics.DrawRectangle(cerceve, rect);
                    e.Graphics.DrawString(hucreDegeri, yaziFontu, firca, new RectangleF(rect.X + 5, rect.Y + 5, rect.Width - 10, rect.Height), new StringFormat() { FormatFlags = StringFormatFlags.LineLimit });
                }

                y += satirYuksekligi;

                // Sayfa taşarsa
                if (y + satirYuksekligi > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;

        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            DateTime baslangic = dateTime_baslangic.Value.Date;
            DateTime bitis = dateTime_bitis.Value.Date;

            string filtre = $"acilis_tarihi >= '#{baslangic:dd/MM/yyyy}#' AND acilis_tarihi <= '#{bitis:dd/MM/yyyy}#'";

            try
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = filtre;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filtreleme hatası: " + ex.Message);
            }
        }
    }
}
