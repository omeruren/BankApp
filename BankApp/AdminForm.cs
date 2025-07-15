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
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
namespace BankApp
{
    public partial class AdminForm : Form
    {
        private int kullaniciID = 0;
        public AdminForm()
        {
            InitializeComponent();
        }

        public AdminForm(int kullaniciID)
        {
            this.kullaniciID = kullaniciID;
            InitializeComponent();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {

            BankStatistics();
            GosterGrafik();
            AyarlaIslemTurleriChart();
        }

        private void AyarlaIslemTurleriChart()
        {
            chart2.Series.Clear(); // chart2 kullanılıyor. İkinci grafik alanı olduğunu varsayıyoruz
            chart2.ChartAreas.Clear();
            chart2.Titles.Clear();

            chart2.Titles.Add("İşlem Türlerine Göre Dağılım");

            ChartArea area = new ChartArea("Alan1");
            chart2.ChartAreas.Add(area);

            Series seri = new Series("İşlemTürleri");
            seri.ChartType = SeriesChartType.Pie;
            seri.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            seri.IsValueShownAsLabel = true; // yüzde oranlarını göster
            seri.LabelForeColor = Color.Black;

            chart2.Series.Add(seri);

            string sorgu = @"SELECT islem_turu, COUNT(*) AS adet FROM Islemler GROUP BY islem_turu ORDER BY adet DESC";

            using (SqlCommand cmd = new SqlCommand(sorgu, Connection.conn))
            {
                Connection.conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string tur = reader.GetString(0);
                        int adet = reader.GetInt32(1);

                        chart2.Series["İşlemTürleri"].Points.AddXY(tur, adet);
                        chart2.Series["İşlemTürleri"].Label = "#PERCENT{P1} - #VALX";
                    }
                }
                Connection.conn.Close();
            }


        }
        private void GosterGrafik()
        {
            AyarlariUygula();
            VeriYukle();
        }

        private void VeriYukle()
        {
            string sorgu = @"WITH Gunler AS(SELECT CAST(GETDATE() AS DATE) AS Tarih UNION ALL SELECT DATEADD(DAY, -1, Tarih)
                                FROM Gunler WHERE DATEADD(DAY, -1, Tarih) >= DATEADD(DAY, -6, CAST(GETDATE() AS DATE))),
                                    IslemSayilari AS(SELECT CAST(tarih AS DATE) AS Tarih, COUNT(*) AS IslemSayisi FROM Islemler
                                GROUP BY CAST(tarih AS DATE)) SELECT G.Tarih, ISNULL(I.IslemSayisi, 0) AS IslemSayisi FROM Gunler G
                                LEFT JOIN IslemSayilari I ON G.Tarih = I.Tarih ORDER BY G.Tarih ASC";

            using (SqlCommand cmd = new SqlCommand(sorgu, Connection.conn))
            {
                Connection.conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime tarih = reader.GetDateTime(0);
                        int adet = reader.GetInt32(1);

                        chart1.Series["İşlemler"].Points.AddXY(tarih.ToString("dd.MM.yyyy"), adet);

                    }
                }
                Connection.conn.Close();
            }
        }

        private void AyarlariUygula()
        {

            chart1.Titles.Add("Son 7 Günlük İşlem Sayısı");
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            ChartArea alan = new ChartArea("Alan1");
            alan.AxisX.Title = "Tarih";
            alan.AxisY.Title = "İşlem Sayısı";
            alan.AxisX.LabelStyle.Angle = -45; // Eğik tarih etiketleri
            chart1.ChartAreas.Add(alan);

            Series seri = new Series("İşlemler");
            seri.ChartType = SeriesChartType.Column;
            seri.Color = Color.SteelBlue;
            seri.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            chart1.Series.Add(seri);
        }

        private void BankStatistics()
        {
            try
            {
                Connection.conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT SUM(bakiye) FROM Hesaplar", Connection.conn);
                BankBalance_Label.Text = Convert.ToDecimal(cmd.ExecuteScalar()).ToString() + " ₺";

                SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM Hesaplar", Connection.conn);
                AccCount_Label.Text = Convert.ToInt32(cmd2.ExecuteScalar()).ToString();

                SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM Kullanicilar", Connection.conn);
                UserCount_Label.Text = Convert.ToInt32(cmd3.ExecuteScalar()).ToString();
                Connection.conn.Close();
            }
            catch (Exception ex)
            {
                Connection.conn.Close();
                MessageBox.Show("hata : " + ex.Message);
            }
        }

        private void ListUsers_Button_Click(object sender, EventArgs e)
        {
            Users usersPage = new Users();
            usersPage.ShowDialog();
        }

        private void NewUser_Button_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
        }

        private void ListAccounts_Buttton_Click(object sender, EventArgs e)
        {
            ListAccounts listAccounts = new ListAccounts();
            listAccounts.ShowDialog();
        }

        private void NewAccount_Button_Click(object sender, EventArgs e)
        {
            Admin_Create_Account admin_Create_Account = new Admin_Create_Account();
            admin_Create_Account.ShowDialog();
        }

        private void ListTransactions_Button_Click(object sender, EventArgs e)
        {
            Transaction_History transactionHistory = new Transaction_History();
            transactionHistory.ShowDialog();
        }


        private void RemittanceHistory_Button_Click(object sender, EventArgs e)
        {
            Remittance_History remittance_History = new Remittance_History();
            remittance_History.ShowDialog();
        }
    }
}
