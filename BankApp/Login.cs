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
    public partial class Login : Form
    {

        public SignUp SignUpPage;
        public MusteriForm musteriForm;


        public Login()
        {
            SignUpPage = new SignUp();
            SignUpPage.LoginPage = this;
            InitializeComponent();
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if (tc_text.Text.Trim().Length != 11 || string.IsNullOrEmpty(sifre_text.Text))
            {
                label_error.Text = "Lütfen tüm alanları doldurduğunuzdan emin olunuz.";
                label_error.Visible = true;
                return;
            }

            string hashedPassword = HashPassword.SHAHash(sifre_text.Text);
            try
            {
                Connection.conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT*FROM Kullanicilar WHERE tcno = @tc AND sifre = @sifre", Connection.conn);
                cmd.Parameters.AddWithValue("@tc", tc_text.Text);
                cmd.Parameters.AddWithValue("@sifre", hashedPassword);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string rol = reader["rol"].ToString();
                    int kullaniciID = Convert.ToInt32(reader["kullaniciID"]);

                    if (rol.Equals("Admin"))
                    {
                        Connection.conn.Close();
                        AdminForm frm = new AdminForm(kullaniciID);
                        frm.Show();
                    }
                    else if (rol.Equals("Personel"))
                    {
                        Connection.conn.Close();
                        PersonelForm frm = new PersonelForm(kullaniciID);
                        frm.Show();
                    }
                    else if (rol == "Musteri")
                    {
                        Connection.conn.Close();
                        MusteriForm frm = new MusteriForm(kullaniciID);

                        frm.Show();
                    }

                    this.Hide();

                }
                else
                {
                    label_error.Text = "Geçersiz Tc no veya şifre";
                    label_error.Visible = true;
                }
                reader.Close();
                Connection.conn.Close();

            }
            catch (Exception ex)
            {
                Connection.conn.Close();
                MessageBox.Show("Hata : " + ex.Message);
            }
        }

        private void SignUp_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpPage.Show();
        }

        private void tc_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;

        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }
        }
    }
}
