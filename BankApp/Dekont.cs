using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class Dekont : Form
    {
        private readonly string sender_account_no;
        private readonly string sender_account_name;
        private readonly string reciever_account_no;
        private readonly string reciever_account_name;
        private readonly decimal amount;
        private readonly DateTime remittance_date;
        private readonly string reciever_Adress;


        public Dekont()
        {
            InitializeComponent();
        }

        public Dekont(string sender_account_name, string sender_account_no, string reciever_account_no, string reciever_account_name, decimal amount, DateTime remittance_date, string reciever_adress)
        {
            this.sender_account_name = sender_account_name;
            this.sender_account_no = sender_account_no;
            this.reciever_account_no = reciever_account_no;
            this.reciever_account_name = reciever_account_name;
            this.amount = amount;
            this.remittance_date = remittance_date;
            reciever_Adress = reciever_adress;

            InitializeComponent();
        }
        public Bitmap FormuResmeKaydet(Form form)
        {
            Bitmap bmp = new Bitmap(panelDekont.Width, panelDekont.Height);
            panelDekont.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height));
            return bmp;
        }
        public void FormuPDFYap(Form form)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PDF Dosyası (.pdf)|.pdf";
            saveDialog.Title = "Dekontu PDF Olarak Kaydet";
            saveDialog.FileName = $"Dekont_{DateTime.Now:yyyyMMddHHmmss}.pdf";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = FormuResmeKaydet(form);

                using (FileStream fs = new FileStream(saveDialog.FileName, FileMode.Create))
                {
                    Document doc = new Document(PageSize.A4, 10, 10, 10, 10);
                    PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                    doc.Open();

                    using (MemoryStream ms = new MemoryStream())
                    {
                        bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(ms.ToArray());
                        pdfImage.ScaleToFit(doc.PageSize.Width - 20, doc.PageSize.Height - 20);
                        pdfImage.Alignment = Element.ALIGN_CENTER;
                        doc.Add(pdfImage);
                    }

                    doc.Close();
                }

                MessageBox.Show("PDF başarıyla oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Dekont_Load(object sender, EventArgs e)
        {
            Label_Sender_Account_Number.Text = sender_account_no;
            Label_Sender_Name.Text = sender_account_name;
            Label_Amount.Text = Convert.ToString(amount);
            Label_Date.Text = remittance_date.ToString("MMMM dd, yyyy, HH:mm:ss");
            Label_Reciever_Name.Text = reciever_account_name;
            Label_Reciever_Account_Adress.Text = reciever_Adress;
            Label_Description.Text = "test";
            Label_Sender_Name2.Text = sender_account_no;
            Label_Reciever_Account_Number2.Text = reciever_account_no;
            Label_Amount2.Text = Convert.ToString(amount);
            Label_Description.Text = $"{amount} TRY tutarında eft işeminin yapılmasını, bu işlem için";

        }

        private void Button_Print_Click(object sender, EventArgs e)
        {
            FormuPDFYap(this);
        }
    }
}
