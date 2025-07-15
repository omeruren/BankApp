namespace BankApp
{
    partial class Transaction_History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction_History));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Print_Button = new System.Windows.Forms.Button();
            this.Button_Search = new System.Windows.Forms.Button();
            this.dateTime_baslangic = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTime_bitis = new System.Windows.Forms.DateTimePicker();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Button_onlyRemittence = new System.Windows.Forms.Button();
            this.Button_onlyWithdraw = new System.Windows.Forms.Button();
            this.Button_onlyDeposit = new System.Windows.Forms.Button();
            this.Button_showAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(654, 240);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // Print_Button
            // 
            this.Print_Button.Location = new System.Drawing.Point(796, 241);
            this.Print_Button.Name = "Print_Button";
            this.Print_Button.Size = new System.Drawing.Size(140, 74);
            this.Print_Button.TabIndex = 1;
            this.Print_Button.Text = "Çıktı Oluştur";
            this.Print_Button.UseVisualStyleBackColor = true;
            this.Print_Button.Click += new System.EventHandler(this.Print_Button_Click);
            // 
            // Button_Search
            // 
            this.Button_Search.Location = new System.Drawing.Point(557, 346);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(149, 42);
            this.Button_Search.TabIndex = 2;
            this.Button_Search.Text = "Ara";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // dateTime_baslangic
            // 
            this.dateTime_baslangic.CalendarFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTime_baslangic.Location = new System.Drawing.Point(271, 346);
            this.dateTime_baslangic.Name = "dateTime_baslangic";
            this.dateTime_baslangic.Size = new System.Drawing.Size(200, 22);
            this.dateTime_baslangic.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Başlangıç Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bitiş Tarihi :";
            // 
            // dateTime_bitis
            // 
            this.dateTime_bitis.CalendarFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTime_bitis.Location = new System.Drawing.Point(271, 400);
            this.dateTime_bitis.Name = "dateTime_bitis";
            this.dateTime_bitis.Size = new System.Drawing.Size(200, 22);
            this.dateTime_bitis.TabIndex = 8;
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
            // Button_onlyRemittence
            // 
            this.Button_onlyRemittence.Location = new System.Drawing.Point(882, 81);
            this.Button_onlyRemittence.Name = "Button_onlyRemittence";
            this.Button_onlyRemittence.Size = new System.Drawing.Size(140, 74);
            this.Button_onlyRemittence.TabIndex = 9;
            this.Button_onlyRemittence.Text = "Sadece havale işlemlerini göster";
            this.Button_onlyRemittence.UseVisualStyleBackColor = true;
            this.Button_onlyRemittence.Click += new System.EventHandler(this.Button_onlyRemittence_Click);
            // 
            // Button_onlyWithdraw
            // 
            this.Button_onlyWithdraw.Location = new System.Drawing.Point(727, 161);
            this.Button_onlyWithdraw.Name = "Button_onlyWithdraw";
            this.Button_onlyWithdraw.Size = new System.Drawing.Size(140, 74);
            this.Button_onlyWithdraw.TabIndex = 10;
            this.Button_onlyWithdraw.Text = "Sadece para çekme işlemlerini göster";
            this.Button_onlyWithdraw.UseVisualStyleBackColor = true;
            this.Button_onlyWithdraw.Click += new System.EventHandler(this.Button_onlyWithdraw_Click);
            // 
            // Button_onlyDeposit
            // 
            this.Button_onlyDeposit.Location = new System.Drawing.Point(727, 81);
            this.Button_onlyDeposit.Name = "Button_onlyDeposit";
            this.Button_onlyDeposit.Size = new System.Drawing.Size(140, 74);
            this.Button_onlyDeposit.TabIndex = 11;
            this.Button_onlyDeposit.Text = "Sadece para yatırma işlemlerini göster";
            this.Button_onlyDeposit.UseVisualStyleBackColor = true;
            this.Button_onlyDeposit.Click += new System.EventHandler(this.Button_onlyDeposit_Click);
            // 
            // Button_showAll
            // 
            this.Button_showAll.Location = new System.Drawing.Point(882, 161);
            this.Button_showAll.Name = "Button_showAll";
            this.Button_showAll.Size = new System.Drawing.Size(140, 74);
            this.Button_showAll.TabIndex = 12;
            this.Button_showAll.Text = "Tüm Listeyi Göster";
            this.Button_showAll.UseVisualStyleBackColor = true;
            this.Button_showAll.Click += new System.EventHandler(this.Button_showAll_Click);
            // 
            // Transaction_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 542);
            this.Controls.Add(this.Button_showAll);
            this.Controls.Add(this.Button_onlyDeposit);
            this.Controls.Add(this.Button_onlyWithdraw);
            this.Controls.Add(this.Button_onlyRemittence);
            this.Controls.Add(this.dateTime_bitis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTime_baslangic);
            this.Controls.Add(this.Button_Search);
            this.Controls.Add(this.Print_Button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Transaction_History";
            this.Text = "Transaction History Page";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Print_Button;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.DateTimePicker dateTime_baslangic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTime_bitis;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button Button_onlyRemittence;
        private System.Windows.Forms.Button Button_onlyWithdraw;
        private System.Windows.Forms.Button Button_onlyDeposit;
        private System.Windows.Forms.Button Button_showAll;
    }
}