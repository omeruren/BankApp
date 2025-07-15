using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class MusteriForm : Form
    {
       
        private int kullaniciID = 0;
        
        public MusteriForm()
        {
            InitializeComponent();
        }
        public MusteriForm(int kullaniciID)
        {
            this.kullaniciID = kullaniciID;
            InitializeComponent();
        }
        private void MusteriForm_Load(object sender, EventArgs e)
        {
            try
            {
                HosgeldinMesajiGoster();

                HesaplariListele();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void HesaplariListele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT hesapID, hesap_no, bakiye FROM Hesaplar WHERE kullaniciID = @id", Connection.conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@id", kullaniciID);
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[0].HeaderText = "Hesap Numarası";
            dataGridView1.Columns[1].HeaderText = "Bakiye";
            Connection.conn.Open();

            Connection.conn.Close();
        }

        private void HosgeldinMesajiGoster()
        {
            SqlCommand command = new SqlCommand("SELECT ad_soyad FROM Kullanicilar WHERE kullaniciID = @id", Connection.conn);
            command.Parameters.AddWithValue("@id", kullaniciID);

            Connection.conn.Open();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                label_welcome.Text = "İyi Günler " + reader["ad_soyad"];
            }
            Connection.conn.Close();
        }

        private void Deposit_Money_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir hesap seçiniz.");
                return;
            }

            string hesap_no = dataGridView1.SelectedRows[0].Cells["hesap_no"].Value.ToString();
            Deposit_Money deposit_Money = new Deposit_Money(hesap_no);
            deposit_Money.ShowDialog();
            HesaplariListele();



        }

        private void Withdraw_Money_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir hesap seçiniz.");
                return;
            }
            string hesap_no = dataGridView1.SelectedRows[0].Cells["hesap_no"].Value.ToString();
            Withdraw_Money withdraw_Money = new Withdraw_Money(hesap_no);
            withdraw_Money.ShowDialog();


            HesaplariListele();
        }

        private void MusteriForm_Activated(object sender, EventArgs e)
        {
            HesaplariListele();
        }

        private void Transaction_History_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir hesap seçiniz.");
                return;
            }
            int hesapID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["hesapID"].Value.ToString());
            Transaction_History transaction_History = new Transaction_History(hesapID);
            transaction_History.ShowDialog();
        }

        private void New_Account_Button_Click(object sender, EventArgs e)
        {
            New_Account new_Account = new New_Account(kullaniciID);
            new_Account.ShowDialog();
        }

        private void Remittance_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir hesap seçiniz.");
                return;
            }
            string gonderen_hesap_no = dataGridView1.SelectedRows[0].Cells["hesap_no"].Value.ToString();

            Remittance remittance = new Remittance(gonderen_hesap_no);
            remittance.ShowDialog();
        }

        private void Button_Profile_Click(object sender, EventArgs e)
        {
            Profile profilePage = new Profile(kullaniciID);
            profilePage.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hesap_no = dataGridView1.SelectedRows[0].Cells["hesap_no"].Value.ToString();
            Remittance_History remittance_History = new Remittance_History(hesap_no);
            remittance_History.ShowDialog();
        }
    }
}
