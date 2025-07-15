using System;
using System.CodeDom;
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
    public partial class Withdraw_Money : Form
    {
        private readonly string hesap_no;
        public Withdraw_Money(string hesap_no)
        {
            this.hesap_no = hesap_no; 
            InitializeComponent();
        }
       
        private void Withdraw_Money_Load(object sender, EventArgs e)
        {
            account_label.Text = hesap_no; 
        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {

            if (amount_text.Text == "")
            {
                Result_label.ForeColor = Color.Red;
                Result_label.Text = "Lütfen bir tutar giriniz.";
                Result_label.Visible = true;
                return;
            }
            decimal amount = Convert.ToDecimal(amount_text.Text);

            if (amount <= 0)
            {
                Result_label.ForeColor = Color.Red;
                Result_label.Text = "Lütfen geçerli bir değer giriniz.";
                Result_label.Visible = true;
                return;

            }

            try
            {

                Connection.conn.Open();
                SqlCommand amountCommand = new SqlCommand("SELECT bakiye, hesapID FROM Hesaplar WHERE hesap_no = @hesapNo", Connection.conn);
                amountCommand.Parameters.AddWithValue("@hesapNo", hesap_no);

                SqlDataReader amountDataReader = amountCommand.ExecuteReader();

                if (!amountDataReader.Read())
                {
                    Result_label.ForeColor = Color.Red;
                    Result_label.Text = "Hesap bulunamadı !";
                    Result_label.Visible = true;
                    amountDataReader.Close();
                    Connection.conn.Close();
                    return;
                }

                decimal currentAmount = Convert.ToDecimal(amountDataReader["bakiye"]);
                int accountID = Convert.ToInt32(amountDataReader["hesapID"]);
                amountDataReader.Close();

                if (currentAmount < amount)
                {

                    Result_label.ForeColor = Color.Red;
                    Result_label.Text = "Yetersiz bakiye";
                    Result_label.Visible = true;
                    Connection.conn.Close();
                    return;

                }

                SqlCommand update = new SqlCommand("UPDATE Hesaplar SET bakiye = bakiye - @tutar WHERE hesap_no = @hesapNo", Connection.conn);
                update.Parameters.AddWithValue("@tutar", amount_text.Text);
                update.Parameters.AddWithValue("@hesapNo", hesap_no);
                update.ExecuteNonQuery();

                SqlCommand tracking = new SqlCommand("INSERT INTO Islemler (hesapID,islem_turu, tutar, tarih, aciklama)" +
                     "VALUES ((SELECT hesapID FROM Hesaplar WHERE hesap_no = @hesapNo), 'Çekme', @tutar, GETDATE(), @aciklama)", Connection.conn);

                tracking.Parameters.AddWithValue("@hesapNo", hesap_no);
                tracking.Parameters.AddWithValue("@tutar", amount);
                tracking.Parameters.AddWithValue("@aciklama", "Para çekme islemi");
                tracking.ExecuteNonQuery();
                Connection.conn.Close();

                Result_label.ForeColor = Color.Green;
                Result_label.Visible = true;
                Result_label.Text = "Para Çekildi";
                amount_text.Text = "";

                
            }
            catch (Exception ex)
            {
                Connection.conn.Close();
                MessageBox.Show("hata : " + ex.Message);
            }
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
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
