namespace BankApp
{
    partial class ListAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListAccounts));
            this.DeleteAccount_Button = new System.Windows.Forms.Button();
            this.UpdateAccount_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CreateDate_text = new System.Windows.Forms.DateTimePicker();
            this.Result_Label = new System.Windows.Forms.Label();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Submit_Button = new System.Windows.Forms.Button();
            this.AccNo_Text = new System.Windows.Forms.TextBox();
            this.Balance_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_Text = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTime_bitis = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTime_baslangic = new System.Windows.Forms.DateTimePicker();
            this.Button_Search = new System.Windows.Forms.Button();
            this.UserSearch_Button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UserName_text = new System.Windows.Forms.TextBox();
            this.Button_showAll = new System.Windows.Forms.Button();
            this.Print_Button = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteAccount_Button
            // 
            this.DeleteAccount_Button.Location = new System.Drawing.Point(509, 295);
            this.DeleteAccount_Button.Name = "DeleteAccount_Button";
            this.DeleteAccount_Button.Size = new System.Drawing.Size(129, 67);
            this.DeleteAccount_Button.TabIndex = 9;
            this.DeleteAccount_Button.Text = "Hesabı Sil";
            this.DeleteAccount_Button.UseVisualStyleBackColor = true;
            this.DeleteAccount_Button.Click += new System.EventHandler(this.DeleteAccount_Button_Click);
            // 
            // UpdateAccount_Button
            // 
            this.UpdateAccount_Button.Location = new System.Drawing.Point(509, 375);
            this.UpdateAccount_Button.Name = "UpdateAccount_Button";
            this.UpdateAccount_Button.Size = new System.Drawing.Size(129, 75);
            this.UpdateAccount_Button.TabIndex = 8;
            this.UpdateAccount_Button.Text = "Hesabı Güncelle";
            this.UpdateAccount_Button.UseVisualStyleBackColor = true;
            this.UpdateAccount_Button.Click += new System.EventHandler(this.UpdateAccount_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CreateDate_text);
            this.groupBox1.Controls.Add(this.Result_Label);
            this.groupBox1.Controls.Add(this.Cancel_Button);
            this.groupBox1.Controls.Add(this.Submit_Button);
            this.groupBox1.Controls.Add(this.AccNo_Text);
            this.groupBox1.Controls.Add(this.Balance_text);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Name_Text);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(664, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 350);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // CreateDate_text
            // 
            this.CreateDate_text.Enabled = false;
            this.CreateDate_text.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.CreateDate_text.Location = new System.Drawing.Point(190, 176);
            this.CreateDate_text.Name = "CreateDate_text";
            this.CreateDate_text.Size = new System.Drawing.Size(200, 30);
            this.CreateDate_text.TabIndex = 13;
            // 
            // Result_Label
            // 
            this.Result_Label.AutoSize = true;
            this.Result_Label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Result_Label.Location = new System.Drawing.Point(36, 230);
            this.Result_Label.Name = "Result_Label";
            this.Result_Label.Size = new System.Drawing.Size(0, 24);
            this.Result_Label.TabIndex = 12;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(230, 269);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(129, 55);
            this.Cancel_Button.TabIndex = 3;
            this.Cancel_Button.Text = "İptal";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Submit_Button
            // 
            this.Submit_Button.Location = new System.Drawing.Point(39, 269);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(129, 55);
            this.Submit_Button.TabIndex = 2;
            this.Submit_Button.Text = "Kaydet";
            this.Submit_Button.UseVisualStyleBackColor = true;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // AccNo_Text
            // 
            this.AccNo_Text.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.AccNo_Text.Location = new System.Drawing.Point(199, 83);
            this.AccNo_Text.MaxLength = 20;
            this.AccNo_Text.Name = "AccNo_Text";
            this.AccNo_Text.Size = new System.Drawing.Size(170, 30);
            this.AccNo_Text.TabIndex = 8;
            // 
            // Balance_text
            // 
            this.Balance_text.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Balance_text.Location = new System.Drawing.Point(199, 127);
            this.Balance_text.Name = "Balance_text";
            this.Balance_text.Size = new System.Drawing.Size(170, 30);
            this.Balance_text.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(82, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Bakiye :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Açılış Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hesap No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad Soyad :";
            // 
            // Name_Text
            // 
            this.Name_Text.Enabled = false;
            this.Name_Text.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Name_Text.Location = new System.Drawing.Point(199, 40);
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(170, 30);
            this.Name_Text.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(605, 263);
            this.dataGridView1.TabIndex = 6;
            // 
            // dateTime_bitis
            // 
            this.dateTime_bitis.CalendarFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTime_bitis.Location = new System.Drawing.Point(252, 375);
            this.dateTime_bitis.Name = "dateTime_bitis";
            this.dateTime_bitis.Size = new System.Drawing.Size(200, 22);
            this.dateTime_bitis.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(29, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Bitiş Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(29, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Başlangıç Tarihi :";
            // 
            // dateTime_baslangic
            // 
            this.dateTime_baslangic.CalendarFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTime_baslangic.Location = new System.Drawing.Point(252, 321);
            this.dateTime_baslangic.Name = "dateTime_baslangic";
            this.dateTime_baslangic.Size = new System.Drawing.Size(200, 22);
            this.dateTime_baslangic.TabIndex = 21;
            // 
            // Button_Search
            // 
            this.Button_Search.Location = new System.Drawing.Point(33, 422);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(149, 42);
            this.Button_Search.TabIndex = 20;
            this.Button_Search.Text = "Ara";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // UserSearch_Button
            // 
            this.UserSearch_Button.Location = new System.Drawing.Point(867, 456);
            this.UserSearch_Button.Name = "UserSearch_Button";
            this.UserSearch_Button.Size = new System.Drawing.Size(149, 42);
            this.UserSearch_Button.TabIndex = 31;
            this.UserSearch_Button.Text = "Ara";
            this.UserSearch_Button.UseVisualStyleBackColor = true;
            this.UserSearch_Button.Click += new System.EventHandler(this.UserSearch_Button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(663, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 24);
            this.label7.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(660, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 24);
            this.label8.TabIndex = 29;
            this.label8.Text = "Kullanıcı Adı";
            // 
            // UserName_text
            // 
            this.UserName_text.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.UserName_text.Location = new System.Drawing.Point(851, 369);
            this.UserName_text.Name = "UserName_text";
            this.UserName_text.Size = new System.Drawing.Size(165, 30);
            this.UserName_text.TabIndex = 28;
            // 
            // Button_showAll
            // 
            this.Button_showAll.Location = new System.Drawing.Point(664, 456);
            this.Button_showAll.Name = "Button_showAll";
            this.Button_showAll.Size = new System.Drawing.Size(129, 74);
            this.Button_showAll.TabIndex = 33;
            this.Button_showAll.Text = "Tüm Listeyi Göster";
            this.Button_showAll.UseVisualStyleBackColor = true;
            this.Button_showAll.Click += new System.EventHandler(this.Button_showAll_Click);
            // 
            // Print_Button
            // 
            this.Print_Button.Location = new System.Drawing.Point(509, 456);
            this.Print_Button.Name = "Print_Button";
            this.Print_Button.Size = new System.Drawing.Size(129, 74);
            this.Print_Button.TabIndex = 32;
            this.Print_Button.Text = "Çıktı Oluştur";
            this.Print_Button.UseVisualStyleBackColor = true;
            this.Print_Button.Click += new System.EventHandler(this.Print_Button_Click);
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
            // ListAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 542);
            this.Controls.Add(this.Button_showAll);
            this.Controls.Add(this.Print_Button);
            this.Controls.Add(this.UserSearch_Button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UserName_text);
            this.Controls.Add(this.dateTime_bitis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTime_baslangic);
            this.Controls.Add(this.Button_Search);
            this.Controls.Add(this.DeleteAccount_Button);
            this.Controls.Add(this.UpdateAccount_Button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListAccounts";
            this.Text = "ListAccounts";
            this.Load += new System.EventHandler(this.ListAccounts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteAccount_Button;
        private System.Windows.Forms.Button UpdateAccount_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Result_Label;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.TextBox AccNo_Text;
        private System.Windows.Forms.TextBox Balance_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name_Text;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker CreateDate_text;
        private System.Windows.Forms.DateTimePicker dateTime_bitis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTime_baslangic;
        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.Button UserSearch_Button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox UserName_text;
        private System.Windows.Forms.Button Button_showAll;
        private System.Windows.Forms.Button Print_Button;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}