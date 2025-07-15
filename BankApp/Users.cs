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
    public partial class Users : Form
    {
        private int satirIndex;
        private int sayfaNo;

        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            ListUsers();
            dataGridView1.Columns[0].Visible = false;
        }

        private void ListUsers()
        {
            DataTable table = new DataTable();

            Connection.conn.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT kullaniciID, ad_soyad, tcno, rol, telefon, email, adres FROM Kullanicilar", Connection.conn);

            cmd.Fill(table);
            dataGridView1.DataSource = table;
            Connection.conn.Close();


        }

        private void UpdateUser_Button_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            Name_Text.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TcNo_Text.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Auth_Text.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Phone_Text.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Mail_Text.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Adress_Text.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
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

                if (TcNo_Text.Text.Count() != 11)
                {
                    Result_Label.ForeColor = Color.Red;
                    Result_Label.Text = "Tc no 11 haneli olmak zorundadır";
                    return;
                }

                if (Phone_Text.Text.Count() != 11)
                {
                    Result_Label.ForeColor = Color.Red;
                    Result_Label.Text = "Telefon numaranız eksik haneli";
                    return;
                }



                Connection.conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Kullanicilar SET" +
                    " ad_soyad = @adsoyad, tcno = @tcno, rol = @rol, telefon = @telefon, email = @mail, adres = @adres WHERE kullaniciID = @id", Connection.conn);

                cmd.Parameters.AddWithValue("adsoyad", Name_Text.Text.Trim());
                cmd.Parameters.AddWithValue("tcno", TcNo_Text.Text.Trim());
                cmd.Parameters.AddWithValue("rol", Auth_Text.Text.Trim());
                cmd.Parameters.AddWithValue("telefon", Phone_Text.Text.Trim());
                cmd.Parameters.AddWithValue("mail", Mail_Text.Text.Trim());
                cmd.Parameters.AddWithValue("adres", Adress_Text.Text.Trim());
                cmd.Parameters.AddWithValue("id", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));


                cmd.ExecuteNonQuery();
                Connection.conn.Close();
                Result_Label.ForeColor = Color.Green;
                Result_Label.Text = "Kullanici başarıyla güncellendi";
                ListUsers();
            }
            catch (Exception ex)
            {
                Connection.conn.Close();
                MessageBox.Show("Hata : " + ex.Message);
            }
        }

        private void DeleteUser_Button_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen bir hesap seçiniz.");
                    return;
                }
                Connection.conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Kullanicilar WHERE kullaniciID = @id", Connection.conn);
                cmd.Parameters.AddWithValue("id", Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

                cmd.ExecuteNonQuery();
                Result_Label.ForeColor = Color.Green;
                Result_Label.Text = "Kullanıcı başarıyla silindi";
                Connection.conn.Close();
                ListUsers();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata : " + ex.Message);
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void UserSearch_Button_Click(object sender, EventArgs e)
        {
            string filter = UserName_text.Text.Trim();
            if (UserName_text.Text.Trim() == "")
            {
                Result_Label2.ForeColor = Color.Red;
                Result_Label2.Text = "Kullanıcı alanı boş kalamaz.";
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
    }
}
