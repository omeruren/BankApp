using Org.BouncyCastle.Ocsp;
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
    public partial class Remittance_History : Form
    {
        private readonly string hesap_no;
        int satirIndex = 0;
        int sayfaNo = 1;
        public Remittance_History()
        {
            InitializeComponent();
            DataTable dataTable1 = new DataTable();
            Connection.conn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(" SELECT H.havaleID, Gonderen.ad_soyad AS GonderenAdSoyad, " +
                "Alici.ad_soyad AS AliciAdSoyad, H.tutar, H.tarih, H.aciklama FROM Havale H " +
                "INNER JOIN Hesaplar GH ON H.gonderen_hesapID = GH.hesapID " +
                "INNER JOIN Kullanicilar Gonderen ON GH.kullaniciID = Gonderen.kullaniciID " +
                "INNER JOIN Hesaplar AH ON H.alici_hesapID = AH.hesapID " +
                "INNER JOIN Kullanicilar Alici ON AH.kullaniciID = Alici.kullaniciID ", Connection.conn);

            dataAdapter.Fill(dataTable1);
            dataGridView1.DataSource = dataTable1;
            Connection.conn.Close();

        }
        public Remittance_History(string hesap_no)
        {
            InitializeComponent();
            this.hesap_no = hesap_no;
            ListRemittanceHistory();
        }

        private void ListRemittanceHistory()
        {

            try
            {

                DataTable dataTable = new DataTable();
                Connection.conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(" SELECT H.havaleID, Gonderen.ad_soyad AS GonderenAdSoyad, " +
                    "Alici.ad_soyad AS AliciAdSoyad, H.tutar, H.tarih, H.aciklama FROM Havale H " +
                    "INNER JOIN Hesaplar GH ON H.gonderen_hesapID = GH.hesapID " +
                    "INNER JOIN Kullanicilar Gonderen ON GH.kullaniciID = Gonderen.kullaniciID " +
                    "INNER JOIN Hesaplar AH ON H.alici_hesapID = AH.hesapID " +
                    "INNER JOIN Kullanicilar Alici ON AH.kullaniciID = Alici.kullaniciID " +
                    "WHERE GH.hesap_no = @hesapno OR AH.hesap_no= @hesapno", Connection.conn);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@hesapno", hesap_no);
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


        private void Remittance_History_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Gönderen";
            dataGridView1.Columns[2].HeaderText = "Alıcı";

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
            string baslik = "Kullanıcı Çıktısı";
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
                    dt.DefaultView.RowFilter = $"GonderenAdSoyad LIKE '%{filter}%' OR AliciAdSoyad LIKE '%{filter}%'";
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
    }
}
