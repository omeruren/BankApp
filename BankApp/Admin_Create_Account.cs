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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BankApp
{
    public partial class Admin_Create_Account : Form
    {
        public Admin_Create_Account()
        {
            InitializeComponent();
        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (Control item in groupBox2.Controls)
                {

                    if (item is TextBox && item.Text == "")
                    {
                        Result_Label.ForeColor = Color.Red;
                        Result_Label.Text = "Boş alan bırakamazsınız.";
                        return;
                    }

                }

                Connection.conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT kullaniciID FROM Kullanicilar WHERE tcno = @tcno", Connection.conn);
                cmd.Parameters.AddWithValue("tcno", User_TcNo_text.Text.Trim());

                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                if (!sqlDataReader.Read())
                {
                    Result_Label.ForeColor = Color.Red;
                    Result_Label.Text = "Tc no bulunamadı.";
                    Connection.conn.Close();
                    return;
                }

                int kullaniciID = Convert.ToInt32(sqlDataReader["kullaniciID"].ToString());
                sqlDataReader.Close();

                SqlCommand cmd2 = new SqlCommand("INSERT INTO Hesaplar VALUES (@kullaniciID, @hesap_no, @bakiye, GETDATE())", Connection.conn);
                cmd2.Parameters.AddWithValue("kullaniciID", kullaniciID);
                cmd2.Parameters.AddWithValue("hesap_no", Account_No_text.Text.Trim());
                cmd2.Parameters.AddWithValue("bakiye", Convert.ToDecimal(Amount_text.Text.Trim()));

                cmd2.ExecuteNonQuery();

                Result_Label.ForeColor = Color.Green;
                Result_Label.Text = "Hesap Oluşturuldu.";
                Connection.conn.Close();


            }
            catch (Exception ex)
            {
                Connection.conn.Close();
                MessageBox.Show("Hata :" + ex.Message);
            }
        }
    }
}
