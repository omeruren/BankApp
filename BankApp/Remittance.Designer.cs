namespace BankApp
{
    partial class Remittance
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
            this.label2 = new System.Windows.Forms.Label();
            this.Reciever_Account_No_text = new System.Windows.Forms.TextBox();
            this.Submit_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Result_Label = new System.Windows.Forms.Label();
            this.Reciever_Name_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Description_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Amount_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Button_Dekont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alıcı Hesap Numarası :";
            // 
            // Reciever_Account_No_text
            // 
            this.Reciever_Account_No_text.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Reciever_Account_No_text.Location = new System.Drawing.Point(300, 57);
            this.Reciever_Account_No_text.Name = "Reciever_Account_No_text";
            this.Reciever_Account_No_text.Size = new System.Drawing.Size(151, 30);
            this.Reciever_Account_No_text.TabIndex = 5;
            this.Reciever_Account_No_text.Text = "555666777";
            this.Reciever_Account_No_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Reciever_Account_No_text_KeyPress);
            // 
            // Submit_Button
            // 
            this.Submit_Button.Location = new System.Drawing.Point(43, 265);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(128, 51);
            this.Submit_Button.TabIndex = 6;
            this.Submit_Button.Text = "Onayla";
            this.Submit_Button.UseVisualStyleBackColor = true;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(211, 265);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(128, 51);
            this.Cancel_Button.TabIndex = 7;
            this.Cancel_Button.Text = "İptal";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Result_Label
            // 
            this.Result_Label.AutoSize = true;
            this.Result_Label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Result_Label.Location = new System.Drawing.Point(26, 215);
            this.Result_Label.Name = "Result_Label";
            this.Result_Label.Size = new System.Drawing.Size(0, 24);
            this.Result_Label.TabIndex = 9;
            this.Result_Label.Visible = false;
            // 
            // Reciever_Name_text
            // 
            this.Reciever_Name_text.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Reciever_Name_text.Location = new System.Drawing.Point(300, 129);
            this.Reciever_Name_text.MaxLength = 50;
            this.Reciever_Name_text.Name = "Reciever_Name_text";
            this.Reciever_Name_text.Size = new System.Drawing.Size(151, 30);
            this.Reciever_Name_text.TabIndex = 11;
            this.Reciever_Name_text.Text = "İbrahim Parlak";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(143, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = " Ad Soyad :";
            // 
            // Description_text
            // 
            this.Description_text.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Description_text.Location = new System.Drawing.Point(300, 165);
            this.Description_text.MaxLength = 255;
            this.Description_text.Name = "Description_text";
            this.Description_text.Size = new System.Drawing.Size(151, 30);
            this.Description_text.TabIndex = 13;
            this.Description_text.Text = "test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(154, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Açıklama :";
            // 
            // Amount_text
            // 
            this.Amount_text.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Amount_text.Location = new System.Drawing.Point(300, 93);
            this.Amount_text.Name = "Amount_text";
            this.Amount_text.Size = new System.Drawing.Size(151, 30);
            this.Amount_text.TabIndex = 15;
            this.Amount_text.Text = "10";
            this.Amount_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Amount_text_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(188, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tutar :";
            // 
            // Button_Dekont
            // 
            this.Button_Dekont.Location = new System.Drawing.Point(372, 265);
            this.Button_Dekont.Name = "Button_Dekont";
            this.Button_Dekont.Size = new System.Drawing.Size(128, 51);
            this.Button_Dekont.TabIndex = 16;
            this.Button_Dekont.Text = "Dekontu Görüntüle";
            this.Button_Dekont.UseVisualStyleBackColor = true;
            this.Button_Dekont.Visible = false;
            this.Button_Dekont.Click += new System.EventHandler(this.Button_Dekont_Click);
            // 
            // Remittance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 346);
            this.Controls.Add(this.Button_Dekont);
            this.Controls.Add(this.Amount_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Description_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Reciever_Name_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Result_Label);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Submit_Button);
            this.Controls.Add(this.Reciever_Account_No_text);
            this.Controls.Add(this.label2);
            this.Name = "Remittance";
            this.Text = "Remittance";
            this.Load += new System.EventHandler(this.Remittance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Reciever_Account_No_text;
        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Label Result_Label;
        private System.Windows.Forms.TextBox Reciever_Name_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Description_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Amount_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button_Dekont;
    }
}