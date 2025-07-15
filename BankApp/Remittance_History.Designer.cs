namespace BankApp
{
    partial class Remittance_History
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remittance_History));
            this.dateTime_bitis = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTime_baslangic = new System.Windows.Forms.DateTimePicker();
            this.Button_Search = new System.Windows.Forms.Button();
            this.Print_Button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Button_showAll = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.UserName_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Result_Label = new System.Windows.Forms.Label();
            this.UserSearch_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTime_bitis
            // 
            this.dateTime_bitis.CalendarFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTime_bitis.Location = new System.Drawing.Point(250, 400);
            this.dateTime_bitis.Name = "dateTime_bitis";
            this.dateTime_bitis.Size = new System.Drawing.Size(200, 22);
            this.dateTime_bitis.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Bitiş Tarihi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Başlangıç Tarihi :";
            // 
            // dateTime_baslangic
            // 
            this.dateTime_baslangic.CalendarFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTime_baslangic.Location = new System.Drawing.Point(250, 346);
            this.dateTime_baslangic.Name = "dateTime_baslangic";
            this.dateTime_baslangic.Size = new System.Drawing.Size(200, 22);
            this.dateTime_baslangic.TabIndex = 16;
            // 
            // Button_Search
            // 
            this.Button_Search.Location = new System.Drawing.Point(487, 368);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(149, 42);
            this.Button_Search.TabIndex = 15;
            this.Button_Search.Text = "Ara";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // Print_Button
            // 
            this.Print_Button.Location = new System.Drawing.Point(834, 247);
            this.Print_Button.Name = "Print_Button";
            this.Print_Button.Size = new System.Drawing.Size(140, 74);
            this.Print_Button.TabIndex = 14;
            this.Print_Button.Text = "Çıktı Oluştur";
            this.Print_Button.UseVisualStyleBackColor = true;
            this.Print_Button.Click += new System.EventHandler(this.Print_Button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(778, 240);
            this.dataGridView1.TabIndex = 13;
            // 
            // Button_showAll
            // 
            this.Button_showAll.Location = new System.Drawing.Point(1046, 247);
            this.Button_showAll.Name = "Button_showAll";
            this.Button_showAll.Size = new System.Drawing.Size(140, 74);
            this.Button_showAll.TabIndex = 23;
            this.Button_showAll.Text = "Tüm Listeyi Göster";
            this.Button_showAll.UseVisualStyleBackColor = true;
            this.Button_showAll.Click += new System.EventHandler(this.Button_showAll_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // UserName_text
            // 
            this.UserName_text.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.UserName_text.Location = new System.Drawing.Point(1021, 75);
            this.UserName_text.Name = "UserName_text";
            this.UserName_text.Size = new System.Drawing.Size(165, 30);
            this.UserName_text.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(830, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // Result_Label
            // 
            this.Result_Label.AutoSize = true;
            this.Result_Label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Result_Label.Location = new System.Drawing.Point(833, 144);
            this.Result_Label.Name = "Result_Label";
            this.Result_Label.Size = new System.Drawing.Size(0, 24);
            this.Result_Label.TabIndex = 26;
            // 
            // UserSearch_Button
            // 
            this.UserSearch_Button.Location = new System.Drawing.Point(1037, 176);
            this.UserSearch_Button.Name = "UserSearch_Button";
            this.UserSearch_Button.Size = new System.Drawing.Size(149, 42);
            this.UserSearch_Button.TabIndex = 27;
            this.UserSearch_Button.Text = "Ara";
            this.UserSearch_Button.UseVisualStyleBackColor = true;
            this.UserSearch_Button.Click += new System.EventHandler(this.UserSearch_Button_Click);
            // 
            // Remittance_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 558);
            this.Controls.Add(this.UserSearch_Button);
            this.Controls.Add(this.Result_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserName_text);
            this.Controls.Add(this.Button_showAll);
            this.Controls.Add(this.dateTime_bitis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTime_baslangic);
            this.Controls.Add(this.Button_Search);
            this.Controls.Add(this.Print_Button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Remittance_History";
            this.Text = "Remittance_History";
            this.Load += new System.EventHandler(this.Remittance_History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTime_bitis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTime_baslangic;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.Button Print_Button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Button_showAll;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox UserName_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Result_Label;
        private System.Windows.Forms.Button UserSearch_Button;
    }
}