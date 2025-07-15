namespace BankApp
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Result_Label = new System.Windows.Forms.Label();
            this.Adress_Text = new System.Windows.Forms.TextBox();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Mail_Text = new System.Windows.Forms.TextBox();
            this.Submit_Button = new System.Windows.Forms.Button();
            this.Phone_Text = new System.Windows.Forms.TextBox();
            this.TcNo_Text = new System.Windows.Forms.TextBox();
            this.Auth_Text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_Text = new System.Windows.Forms.TextBox();
            this.UpdateUser_Button = new System.Windows.Forms.Button();
            this.DeleteUser_Button = new System.Windows.Forms.Button();
            this.UserSearch_Button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.UserName_text = new System.Windows.Forms.TextBox();
            this.Button_showAll = new System.Windows.Forms.Button();
            this.Print_Button = new System.Windows.Forms.Button();
            this.Result_Label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(878, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Result_Label);
            this.groupBox1.Controls.Add(this.Adress_Text);
            this.groupBox1.Controls.Add(this.Cancel_Button);
            this.groupBox1.Controls.Add(this.Mail_Text);
            this.groupBox1.Controls.Add(this.Submit_Button);
            this.groupBox1.Controls.Add(this.Phone_Text);
            this.groupBox1.Controls.Add(this.TcNo_Text);
            this.groupBox1.Controls.Add(this.Auth_Text);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Name_Text);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(910, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 437);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Result_Label
            // 
            this.Result_Label.AutoSize = true;
            this.Result_Label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Result_Label.Location = new System.Drawing.Point(9, 318);
            this.Result_Label.Name = "Result_Label";
            this.Result_Label.Size = new System.Drawing.Size(0, 24);
            this.Result_Label.TabIndex = 12;
            // 
            // Adress_Text
            // 
            this.Adress_Text.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Adress_Text.Location = new System.Drawing.Point(199, 259);
            this.Adress_Text.Name = "Adress_Text";
            this.Adress_Text.Size = new System.Drawing.Size(170, 30);
            this.Adress_Text.TabIndex = 11;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(240, 376);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(129, 55);
            this.Cancel_Button.TabIndex = 3;
            this.Cancel_Button.Text = "İptal";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Mail_Text
            // 
            this.Mail_Text.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Mail_Text.Location = new System.Drawing.Point(199, 215);
            this.Mail_Text.Name = "Mail_Text";
            this.Mail_Text.Size = new System.Drawing.Size(170, 30);
            this.Mail_Text.TabIndex = 10;
            // 
            // Submit_Button
            // 
            this.Submit_Button.Location = new System.Drawing.Point(56, 376);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(129, 55);
            this.Submit_Button.TabIndex = 2;
            this.Submit_Button.Text = "Kaydet";
            this.Submit_Button.UseVisualStyleBackColor = true;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // Phone_Text
            // 
            this.Phone_Text.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Phone_Text.Location = new System.Drawing.Point(199, 170);
            this.Phone_Text.MaxLength = 11;
            this.Phone_Text.Name = "Phone_Text";
            this.Phone_Text.Size = new System.Drawing.Size(170, 30);
            this.Phone_Text.TabIndex = 9;
            // 
            // TcNo_Text
            // 
            this.TcNo_Text.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.TcNo_Text.Location = new System.Drawing.Point(199, 83);
            this.TcNo_Text.MaxLength = 11;
            this.TcNo_Text.Name = "TcNo_Text";
            this.TcNo_Text.Size = new System.Drawing.Size(170, 30);
            this.TcNo_Text.TabIndex = 8;
            // 
            // Auth_Text
            // 
            this.Auth_Text.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Auth_Text.Location = new System.Drawing.Point(199, 127);
            this.Auth_Text.Name = "Auth_Text";
            this.Auth_Text.Size = new System.Drawing.Size(170, 30);
            this.Auth_Text.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rol :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tc No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad Soyad :";
            // 
            // Name_Text
            // 
            this.Name_Text.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Name_Text.Location = new System.Drawing.Point(199, 40);
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(170, 30);
            this.Name_Text.TabIndex = 0;
            // 
            // UpdateUser_Button
            // 
            this.UpdateUser_Button.Location = new System.Drawing.Point(574, 341);
            this.UpdateUser_Button.Name = "UpdateUser_Button";
            this.UpdateUser_Button.Size = new System.Drawing.Size(140, 74);
            this.UpdateUser_Button.TabIndex = 4;
            this.UpdateUser_Button.Text = "Kullanıcıyı Güncelle";
            this.UpdateUser_Button.UseVisualStyleBackColor = true;
            this.UpdateUser_Button.Click += new System.EventHandler(this.UpdateUser_Button_Click);
            // 
            // DeleteUser_Button
            // 
            this.DeleteUser_Button.Location = new System.Drawing.Point(428, 338);
            this.DeleteUser_Button.Name = "DeleteUser_Button";
            this.DeleteUser_Button.Size = new System.Drawing.Size(140, 74);
            this.DeleteUser_Button.TabIndex = 5;
            this.DeleteUser_Button.Text = "Kullanıcıyı Sil";
            this.DeleteUser_Button.UseVisualStyleBackColor = true;
            this.DeleteUser_Button.Click += new System.EventHandler(this.DeleteUser_Button_Click);
            // 
            // UserSearch_Button
            // 
            this.UserSearch_Button.Location = new System.Drawing.Point(168, 430);
            this.UserSearch_Button.Name = "UserSearch_Button";
            this.UserSearch_Button.Size = new System.Drawing.Size(149, 42);
            this.UserSearch_Button.TabIndex = 32;
            this.UserSearch_Button.Text = "Ara";
            this.UserSearch_Button.UseVisualStyleBackColor = true;
            this.UserSearch_Button.Click += new System.EventHandler(this.UserSearch_Button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 24);
            this.label7.TabIndex = 31;
            this.label7.Text = "Kullanıcı Adı";
            // 
            // UserName_text
            // 
            this.UserName_text.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.UserName_text.Location = new System.Drawing.Point(152, 341);
            this.UserName_text.Name = "UserName_text";
            this.UserName_text.Size = new System.Drawing.Size(165, 30);
            this.UserName_text.TabIndex = 30;
            // 
            // Button_showAll
            // 
            this.Button_showAll.Location = new System.Drawing.Point(574, 430);
            this.Button_showAll.Name = "Button_showAll";
            this.Button_showAll.Size = new System.Drawing.Size(140, 74);
            this.Button_showAll.TabIndex = 29;
            this.Button_showAll.Text = "Tüm Listeyi Göster";
            this.Button_showAll.UseVisualStyleBackColor = true;
            this.Button_showAll.Click += new System.EventHandler(this.Button_showAll_Click);
            // 
            // Print_Button
            // 
            this.Print_Button.Location = new System.Drawing.Point(428, 430);
            this.Print_Button.Name = "Print_Button";
            this.Print_Button.Size = new System.Drawing.Size(140, 74);
            this.Print_Button.TabIndex = 28;
            this.Print_Button.Text = "Çıktı Oluştur";
            this.Print_Button.UseVisualStyleBackColor = true;
            this.Print_Button.Click += new System.EventHandler(this.Print_Button_Click);
            // 
            // Result_Label2
            // 
            this.Result_Label2.AutoSize = true;
            this.Result_Label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Result_Label2.Location = new System.Drawing.Point(12, 388);
            this.Result_Label2.Name = "Result_Label2";
            this.Result_Label2.Size = new System.Drawing.Size(0, 24);
            this.Result_Label2.TabIndex = 38;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 506);
            this.Controls.Add(this.Result_Label2);
            this.Controls.Add(this.UserSearch_Button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UserName_text);
            this.Controls.Add(this.Button_showAll);
            this.Controls.Add(this.Print_Button);
            this.Controls.Add(this.DeleteUser_Button);
            this.Controls.Add(this.UpdateUser_Button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name_Text;
        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.TextBox Adress_Text;
        private System.Windows.Forms.TextBox Mail_Text;
        private System.Windows.Forms.TextBox Phone_Text;
        private System.Windows.Forms.TextBox TcNo_Text;
        private System.Windows.Forms.TextBox Auth_Text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button UpdateUser_Button;
        private System.Windows.Forms.Button DeleteUser_Button;
        private System.Windows.Forms.Label Result_Label;
        private System.Windows.Forms.Button UserSearch_Button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UserName_text;
        private System.Windows.Forms.Button Button_showAll;
        private System.Windows.Forms.Button Print_Button;
        private System.Windows.Forms.Label Result_Label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}