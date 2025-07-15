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
    public partial class New_Account : Form
    {
        public int kullaniciID { get; }

        public New_Account(int kullaniciID)
        {
            this.kullaniciID = kullaniciID;
            InitializeComponent();
        }
        public New_Account()
        {
            InitializeComponent();
        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            try
            {


                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox && item.Text.Trim() == "")
                    {
                        Result_Label.ForeColor = Color.Red;
                        Result_Label.Text = "Boş alan bırakamazsınız";
                        return;
                    }
                }

                Connection.conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Hesaplar (kullaniciID, hesap_no, bakiye, acilis_tarihi) VALUES " +
                    "(@kullaniciID, @hesap_no, @bakiye, GETDATE())", Connection.conn);
                cmd.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                cmd.Parameters.AddWithValue("@hesap_no", Account_No_text.Text);
                cmd.Parameters.AddWithValue("@bakiye", Convert.ToDecimal(Amount_text.Text));

                cmd.ExecuteNonQuery();
                Connection.conn.Close();
                Result_Label.Visible = true;
                Result_Label.ForeColor = Color.Green;
                Result_Label.Text = "Hesap Oluşturuldu.";

            }
            catch (SqlException ex)
            {
                Connection.conn.Close();

                if (ex.Message.Contains("UNIQUE KEY constraint"))
                    MessageBox.Show("Bu hesap numarası başkası tarafından alınmış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }
        }

        private void Account_No_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void Amount_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }
    }
}
