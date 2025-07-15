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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }



        private void Submit_Button_Click(object sender, EventArgs e)
        {


            try
            {
                foreach (Control item in panel1.Controls)
                {
                    if ((item is TextBox || item is ComboBox) && item.Text == "")
                    {
                        Result_Label.ForeColor = Color.Red;
                        Result_Label.Text = "Boş alan bırakamzsınız.";
                        return;
                    }
                }
                string hashedPassword = HashPassword.SHAHash(Password_text.Text.Trim());
                Connection.conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Kullanicilar", Connection.conn);

                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    if (TcNo_text.Text.Trim() == Convert.ToString(sqlDataReader["tcno"]))
                    {
                        Result_Label.ForeColor = Color.Red;
                        Result_Label.Text = "Böyle bir tc no ya ait bir hesap zaten bulunuyor.";
                        return;
                    }
                }
                sqlDataReader.Close();

                SqlCommand cmd2 = new SqlCommand("INSERT INTO Kullanicilar VALUES (@ad_soyad, @tc, @sifre, @rol, @phone, @email, @adress )", Connection.conn);
                cmd2.Parameters.AddWithValue("ad_soyad", Name_text.Text.Trim());
                cmd2.Parameters.AddWithValue("tc", TcNo_text.Text.Trim());
                cmd2.Parameters.AddWithValue("sifre", hashedPassword);
                cmd2.Parameters.AddWithValue("rol", Auth_combo.Text);
                cmd2.Parameters.AddWithValue("phone", Phone_text.Text.Trim());
                cmd2.Parameters.AddWithValue("email", Mail_text.Text.Trim());
                cmd2.Parameters.AddWithValue("adress", Adress_text.Text.Trim());

                cmd2.ExecuteNonQuery();

                Result_Label.ForeColor = Color.Green;
                Result_Label.Text = "Kullanıcı kaydedildi";

                Connection.conn.Close();
            }
            catch (Exception ex)
            {
                Connection.conn.Close();
                MessageBox.Show("Hata : " + ex.Message);
            }
        }

        private void TcNo_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void Phone_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }
    }
}
