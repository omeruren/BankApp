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
    public partial class Profile : Form
    {
        private int kullaniciID;

        public Profile()
        {
            InitializeComponent();
        }

        public Profile(int kullaniciID)
        {
            this.kullaniciID = kullaniciID;
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            GetProfileInfo(kullaniciID);
        }

        private void GetProfileInfo(int kullaniciID)
        {
            try
            {
                Connection.conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Kullanicilar WHERE kullaniciID = @id", Connection.conn);
                cmd.Parameters.AddWithValue("id", kullaniciID);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Name_text.Text = Convert.ToString(reader["ad_soyad"]);
                    Phone_text.Text = Convert.ToString(reader["telefon"]);
                    Mail_text.Text = Convert.ToString(reader["email"]);
                    Adress_text.Text = Convert.ToString(reader["adres"]);
                    reader.Close();
                }
                Connection.conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata :" + ex.Message);
            }
        }

        private void SaveProfile_Button_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (Control item in groupBox1.Controls)
                {

                    if (item is TextBox && item.Text == "")
                    {
                        Result_Label.ForeColor = Color.Red;
                        Result_Label.Text = "Boş alan bırakamazsınız.";
                        return;
                    }
                }

                Connection.conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE  Kullanicilar SET " +
                    "ad_soyad = @adsoyad, telefon = @telefon, email = @email, adres = @adres WHERE kullaniciID = @id", Connection.conn);
                cmd.Parameters.AddWithValue("adsoyad", Name_text.Text.Trim());
                cmd.Parameters.AddWithValue("telefon", Phone_text.Text.Trim());
                cmd.Parameters.AddWithValue("email", Mail_text.Text.Trim());
                cmd.Parameters.AddWithValue("adres", Adress_text.Text.Trim());
                cmd.Parameters.AddWithValue("id", kullaniciID);

                cmd.ExecuteNonQuery();
                Connection.conn.Close();
                Result_Label.ForeColor = Color.Green;
                Result_Label.Text = "Kullanıcı bilgileri başarıyla kaydedildi.";

            }
            catch (Exception ex)
            {
                Connection.conn.Close();
                MessageBox.Show("Hata : " + ex.Message);
            }

        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            GetProfileInfo(kullaniciID);
        }

        private void SavePass_Button_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox && item.Text == "")
                    {
                        Result_Label2.ForeColor = Color.Red;
                        Result_Label2.Text = "Boş alan bırakamazsınız.";
                        return;
                    }
                }

                if (NewPass_text.Text.Trim() != NewPass2_text.Text.Trim())
                {
                    Result_Label2.ForeColor = Color.Red;
                    Result_Label2.Text = ":Şifreler uyuşmuyor.";
                    return;
                }


                string oldPassword = "";
                string hashdedPassword = HashPassword.SHAHash(NewPass_text.Text.Trim());

                Connection.conn.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT sifre FROM Kullanicilar WHERE kullaniciID = @id", Connection.conn);

                sqlCommand.Parameters.AddWithValue("id", kullaniciID);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {

                    oldPassword = Convert.ToString(sqlDataReader["sifre"]);
                    sqlDataReader.Close();
                }

                if (hashdedPassword.Equals(oldPassword))
                {

                    Result_Label2.ForeColor = Color.Red;
                    Result_Label2.Text = "Yeni şifre ile eski şifreniz aynı olamaz.";
                    Connection.conn.Close();
                    return;
                }

                SqlCommand cmd = new SqlCommand("UPDATE Kullanicilar SET sifre = @sifre WHERE kullaniciID = @id", Connection.conn);

                cmd.Parameters.AddWithValue("sifre", hashdedPassword);
                cmd.Parameters.AddWithValue("id", kullaniciID);

                cmd.ExecuteNonQuery();
                Connection.conn.Close();

                Result_Label2.ForeColor = Color.Green;
                Result_Label2.Text = "Şifre başarıyla değiştirildi";

            }
            catch (Exception ex)
            {
                Connection.conn.Close();
                MessageBox.Show("hata : " + ex.Message);
            }
        }

        private void Cancel2_Button_Click(object sender, EventArgs e)
        {
            NewPass_text.Text = "";
            NewPass2_text.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item.Enabled == false)
                {
                    item.Enabled = true;
                }
            }

            foreach (Control item in groupBox2.Controls)
            {
                if (item.Enabled == false)
                {
                    item.Enabled = true;
                }
            }
        }
    }
}
