using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class Deposit_Money : Form
    {
        private readonly string hesap_no;

        public Deposit_Money(string hesap_no)
        {
            this.hesap_no = hesap_no;
            InitializeComponent();
        }
        public Deposit_Money()
        {
        }
        private void Deposit_Money_Load(object sender, EventArgs e)
        {
            account_label.Text = hesap_no;
        }
        private void Submit_Button_Click(object sender, EventArgs e)
        {
            if (amount_text.Text == "")
            {
                Result_Label.ForeColor = Color.Red;
                Result_Label.Text = "Lütfen bir tutar giriniz.";
                return;
            }
            decimal amount = Convert.ToDecimal(amount_text.Text);

            if (amount <= 0)
            {
                Result_Label.ForeColor = Color.Red;
                Result_Label.Text = "Lütfen geçerli bir değer giriniz.";
                return;

            }

            try
            {
                Connection.conn.Open();
                SqlCommand command = new SqlCommand("UPDATE Hesaplar SET bakiye = bakiye + @tutar WHERE hesap_no = @hesapNo", Connection.conn);
                command.Parameters.AddWithValue("@hesapNo", hesap_no);
                command.Parameters.AddWithValue("@tutar", Convert.ToDecimal(amount_text.Text));
                command.ExecuteNonQuery();

                SqlCommand tracking = new SqlCommand("INSERT INTO Islemler (hesapID,islem_turu, tutar, tarih, aciklama)" +
                    "VALUES ((SELECT hesapID FROM Hesaplar WHERE hesap_no = @hesapNo), 'Yatırma', @tutar, GETDATE(), @aciklama)", Connection.conn);

                tracking.Parameters.AddWithValue("@hesapNo", hesap_no);
                tracking.Parameters.AddWithValue("@tutar", amount);
                tracking.Parameters.AddWithValue("@aciklama", "Para yatirma islemi");
                tracking.ExecuteNonQuery();
                Connection.conn.Close();

                Result_Label.ForeColor = Color.Green;
                Result_Label.Text = "Para yatırıldı";
                Result_Label.Visible = true;
                amount_text.Text = "";


            }
            catch (Exception ex)
            {
                Connection.conn.Close();
                MessageBox.Show("hata : " + ex.Message);
            }


        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }
        }

        private void amount_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }
    }
}
