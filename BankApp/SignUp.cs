using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class SignUp :  Form, ILinkForms
    {
        public Login LoginPage { get; set; }
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Button_Click(object sender, EventArgs e)
        {
            if(ad_soyad_text.Text == "" || tc_no_text.Text.Length != 11 || sifre_text.Text == "")
            {
                Result_Label.ForeColor = Color.Red;
                Result_Label.Text = "Lütfen tüm alanları doldurduğunuzdan emin olunuz.";
                Result_Label.Visible = true;
                return;
            }

            string hashedPassword = HashPassword.SHAHash(sifre_text.Text);

            try
            {
                Connection.conn.Open();
                string sql = 
                    "INSERT INTO Kullanicilar (ad_soyad,tcno,sifre,rol,telefon,email,adres)" +
                    " VALUES (@adsoyad, @tcno, @sifre, @rol, @telefon,@email, @adres)";
               
                SqlCommand command = new SqlCommand(sql, Connection.conn);

                command.Parameters.AddWithValue("@adsoyad", ad_soyad_text.Text);
                command.Parameters.AddWithValue("@tcno",tc_no_text.Text);
                command.Parameters.AddWithValue("@sifre", hashedPassword);
                command.Parameters.AddWithValue("@rol", "Musteri");
                command.Parameters.AddWithValue("@telefon", tel_text.Text);
                command.Parameters.AddWithValue("@email", email_text.Text);
                command.Parameters.AddWithValue("@adres", adres_text.Text);

                int sonuc = command.ExecuteNonQuery();
                Connection.conn.Close();

                if (sonuc > 0) {

                    Result_Label.ForeColor = Color.Green;
                    Result_Label.Text = "Kayit başarıyla tamamlandı";
                    Result_Label.Visible = true;
                    Temizle();
                }
            }
            catch (Exception ex)
            {
                Connection.conn.Close();
                MessageBox.Show("Hata : " + ex.Message);
            }
        }

        private void Temizle()
        {
            ad_soyad_text.Text = "";
            sifre_text.Text = "";
            tc_no_text.Text = "";
            sifre_text.Text = "";
            tel_text.Text = "";
            email_text.Text = "";
            adres_text.Text = "";
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is TextBox) {

                    item.Text = "";
                   
                }
            }
        }

        private void tc_no_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void tel_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }
    }
}
