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
    public partial class Remittance : Form
    {
        private string gonderen_hesap_no, sender_account_name, reciever_account_no, reciever_account_name,reciever_adress, description;
        DateTime remittance_date;
        private decimal amount = 0;

        public Remittance()
        {
            InitializeComponent();
        }

        public Remittance(string gonderen_hesap_no)
        {
            this.gonderen_hesap_no = gonderen_hesap_no;
            InitializeComponent();
        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {

            reciever_account_no = Reciever_Account_No_text.Text.Trim();


            if (Reciever_Account_No_text.Text.Trim() == "" || Amount_text.Text.Trim() == "" || Reciever_Name_text.Text.Trim() == "" || Description_text.Text.Trim() == "")
            {

                Result_Label.ForeColor = Color.Red;
                Result_Label.Visible = true;
                Result_Label.Text = "Hata : Lütfen tüm alanları doldurduğunuzdan emin olunuz.";
                return;
            }

            if (!decimal.TryParse(Amount_text.Text, out decimal amount) || amount <= 0)
            {
                Result_Label.ForeColor = Color.Red;
                Result_Label.Visible = true;
                Result_Label.Text = "Hata : Lütfen Geçerli bir tutar giriniz.";
                return;
            }



            if (Reciever_Account_No_text.Text.Trim() == gonderen_hesap_no)
            {
                Result_Label.ForeColor = Color.Red;
                Result_Label.Visible = true;
                Result_Label.Text = "Hata : Kendi hesabınıza havale yapamazsınız.";
                return;
            }

            try
            {
                Connection.conn.Open();
                SqlCommand sqlGonderen = new SqlCommand("SELECT hesapID, bakiye FROM Hesaplar WHERE hesap_no = @hesapNo", Connection.conn);
                sqlGonderen.Parameters.AddWithValue("@hesapNo", gonderen_hesap_no);
                SqlDataReader sqlDataReader = sqlGonderen.ExecuteReader();



                if (!sqlDataReader.Read())
                {
                    sqlDataReader.Close();
                    throw new Exception("Gönderen hesap bulunamadı.");
                }

                int gonderenID = Convert.ToInt32(sqlDataReader["hesapID"]);
                decimal current_amount = Convert.ToDecimal(sqlDataReader["bakiye"]);
                sqlDataReader.Close();
                
                SqlCommand gonderenSqlKullaniciAd = new SqlCommand("SELECT A.hesap_no, B.ad_soyad FROM Hesaplar A INNER JOIN Kullanicilar B ON A.kullaniciID = B.kullaniciID WHERE A.hesap_no = @hesap_no", Connection.conn);
                gonderenSqlKullaniciAd.Parameters.AddWithValue("@hesap_no", gonderen_hesap_no);

                SqlDataReader sqlDataReader2 = gonderenSqlKullaniciAd.ExecuteReader();

                if (sqlDataReader2.Read())
                {
                    sender_account_name = sqlDataReader2["ad_soyad"].ToString();
                }
                sqlDataReader2.Close();


                SqlCommand aliciSqlAdress = new SqlCommand("SELECT C.adres FROM Hesaplar D INNER JOIN Kullanicilar C ON D.kullaniciID = C.kullaniciID WHERE D.hesap_no  = @alicihesap_no", Connection.conn);
                aliciSqlAdress.Parameters.AddWithValue("@alicihesap_no", reciever_account_no);

                SqlDataReader sqlDataReader3 = aliciSqlAdress.ExecuteReader();

                if (sqlDataReader3.Read())
                {
                    reciever_adress = sqlDataReader3["adres"].ToString();
                }
                sqlDataReader3.Close();

                SqlCommand sqlKullaniciAd = new SqlCommand("SELECT H.hesapID, H.hesap_no, H.bakiye, K.ad_soyad FROM Hesaplar H INNER JOIN Kullanicilar K ON H.kullaniciID = K.kullaniciID WHERE H.hesap_no = @hesap_no", Connection.conn);
                sqlKullaniciAd.Parameters.AddWithValue("@hesap_no", Reciever_Account_No_text.Text.Trim());

                SqlDataReader kullaniciReader = sqlKullaniciAd.ExecuteReader();

                if (kullaniciReader.Read())
                {

                    string kullaniciAd = Convert.ToString(kullaniciReader["ad_soyad"]);

                    if (kullaniciAd != Reciever_Name_text.Text)
                    {
                        Result_Label.Text = "Hata : Alıcı bilgisi ile Hesap Numarası sahibi uyuşmamaktadır.";
                        Result_Label.Visible = true;
                        Result_Label.ForeColor = Color.Red;
                        return;
                    }
                    kullaniciReader.Close();
                }



                if (current_amount < 0)
                    throw new Exception("Yetersiz bakiye.");

                SqlCommand SqlAlici = new SqlCommand("SELECT hesapID FROM Hesaplar WHERE hesap_no = @hesapNo", Connection.conn);
                SqlAlici.Parameters.AddWithValue("@hesapNo", Reciever_Account_No_text.Text.Trim());
                SqlDataReader sqlDataReader1 = SqlAlici.ExecuteReader();

                if (!sqlDataReader1.Read())
                {
                    sqlDataReader1.Close();
                    throw new Exception("Alıcı hesap bulunamadı.");
                }
               
                int aliciHesap = Convert.ToInt32(sqlDataReader1["hesapID"]);
                sqlDataReader1.Close();
                SqlTransaction sqlTransaction = Connection.conn.BeginTransaction();

                try
                {
                    SqlCommand updateG = new SqlCommand("UPDATE Hesaplar SET bakiye = bakiye - @amount WHERE hesapID = @hesapID", Connection.conn, sqlTransaction);
                    updateG.Parameters.AddWithValue("@amount", amount);
                    updateG.Parameters.AddWithValue("@hesapID", gonderenID);
                    updateG.ExecuteNonQuery();

                    SqlCommand insertG = new SqlCommand("UPDATE Hesaplar SET bakiye = bakiye + @tutar WHERE hesapID = @hesapID", Connection.conn, sqlTransaction);
                    insertG.Parameters.AddWithValue("@tutar", amount);
                    insertG.Parameters.AddWithValue("@hesapID", aliciHesap);
                    insertG.ExecuteNonQuery();

                    SqlCommand islem1 = new SqlCommand(@"
                                        INSERT INTO Islemler (hesapID, islem_turu, tutar, tarih, aciklama, hedef_hesapID)
                                        VALUES (@id, 'Havale', @tutar, GETDATE(), @aciklama, @hedefID)", Connection.conn, sqlTransaction);
                    islem1.Parameters.AddWithValue("@id", gonderenID);
                    islem1.Parameters.AddWithValue("@tutar", amount);
                    islem1.Parameters.AddWithValue("@aciklama", "Havale İşlemi");
                    islem1.Parameters.AddWithValue("@hedefID", aliciHesap);
                    islem1.ExecuteNonQuery();



                    SqlCommand Sqlremittance = new SqlCommand("INSERT INTO Havale (gonderen_hesapID, alici_hesapID, tutar, aciklama) VALUES" +
                        " (@gonderen, @alici, @tutar, @aciklama)", Connection.conn, sqlTransaction);
                    Sqlremittance.Parameters.AddWithValue("@gonderen", gonderenID);
                    Sqlremittance.Parameters.AddWithValue("@alici", aliciHesap);
                    Sqlremittance.Parameters.AddWithValue("@tutar", amount);
                    Sqlremittance.Parameters.AddWithValue("@aciklama", Description_text.Text.Trim());

                    Sqlremittance.ExecuteNonQuery();
                    sqlTransaction.Commit();
                }
                catch (Exception ex)
                {
                    Connection.conn.Close();
                    sqlTransaction.Rollback();
                    MessageBox.Show("Hata : " + ex.Message);
                    throw;
                }


                Result_Label.Text = "Havale işlemi başarıyla tamamlandı.";
                Result_Label.ForeColor = Color.Green;
                Result_Label.Visible = true;
                Button_Dekont.Visible = true;

                
                reciever_account_name = Reciever_Name_text.Text.Trim();
                
                this.amount = amount;
                remittance_date = DateTime.Now;
                Connection.conn.Close();
            }
            catch (Exception ex)
            {
                Connection.conn.Close();
                MessageBox.Show("Hata : " + ex.Message);
            }

        }

        private void Remittance_Load(object sender, EventArgs e)
        {

        }

        private void Reciever_Account_No_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void Amount_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
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

        private void Button_Dekont_Click(object sender, EventArgs e)
        {
            string sender_account_no = this.gonderen_hesap_no, reciever_account_no = this.reciever_account_no, reciever_account_name = this.reciever_account_name;
            DateTime remittance_date = this.remittance_date;
            decimal amount = this.amount;
            Dekont dekont = new Dekont(sender_account_name, sender_account_no, reciever_account_no, reciever_account_name, amount, remittance_date,reciever_adress);
            dekont.ShowDialog();
        }
    }
}
