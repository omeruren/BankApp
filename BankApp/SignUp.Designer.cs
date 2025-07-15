namespace BankApp
{
    partial class SignUp
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
            this.ad_soyad_text = new System.Windows.Forms.TextBox();
            this.tc_no_text = new System.Windows.Forms.TextBox();
            this.sifre_text = new System.Windows.Forms.TextBox();
            this.tel_text = new System.Windows.Forms.TextBox();
            this.email_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.adres_text = new System.Windows.Forms.TextBox();
            this.SignUp_Button = new System.Windows.Forms.Button();
            this.Result_Label = new System.Windows.Forms.Label();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ad_soyad_text
            // 
            this.ad_soyad_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ad_soyad_text.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ad_soyad_text.Location = new System.Drawing.Point(237, 16);
            this.ad_soyad_text.Name = "ad_soyad_text";
            this.ad_soyad_text.Size = new System.Drawing.Size(147, 30);
            this.ad_soyad_text.TabIndex = 0;
            // 
            // tc_no_text
            // 
            this.tc_no_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tc_no_text.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tc_no_text.Location = new System.Drawing.Point(237, 71);
            this.tc_no_text.MaxLength = 11;
            this.tc_no_text.Name = "tc_no_text";
            this.tc_no_text.Size = new System.Drawing.Size(147, 30);
            this.tc_no_text.TabIndex = 1;
            this.tc_no_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tc_no_text_KeyPress);
            // 
            // sifre_text
            // 
            this.sifre_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sifre_text.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_text.Location = new System.Drawing.Point(237, 124);
            this.sifre_text.Name = "sifre_text";
            this.sifre_text.Size = new System.Drawing.Size(147, 30);
            this.sifre_text.TabIndex = 2;
            // 
            // tel_text
            // 
            this.tel_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tel_text.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tel_text.Location = new System.Drawing.Point(237, 173);
            this.tel_text.MaxLength = 11;
            this.tel_text.Name = "tel_text";
            this.tel_text.Size = new System.Drawing.Size(147, 30);
            this.tel_text.TabIndex = 3;
            this.tel_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tel_text_KeyPress);
            // 
            // email_text
            // 
            this.email_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_text.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.email_text.Location = new System.Drawing.Point(237, 226);
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(147, 30);
            this.email_text.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(108, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(142, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tc No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(155, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(129, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(146, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(143, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Adres";
            // 
            // adres_text
            // 
            this.adres_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adres_text.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adres_text.Location = new System.Drawing.Point(237, 276);
            this.adres_text.Name = "adres_text";
            this.adres_text.Size = new System.Drawing.Size(147, 30);
            this.adres_text.TabIndex = 12;
            // 
            // SignUp_Button
            // 
            this.SignUp_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SignUp_Button.Location = new System.Drawing.Point(178, 407);
            this.SignUp_Button.Name = "SignUp_Button";
            this.SignUp_Button.Size = new System.Drawing.Size(127, 58);
            this.SignUp_Button.TabIndex = 13;
            this.SignUp_Button.Text = "Kayıt Ol";
            this.SignUp_Button.UseVisualStyleBackColor = false;
            this.SignUp_Button.Click += new System.EventHandler(this.SignUp_Button_Click);
            // 
            // Result_Label
            // 
            this.Result_Label.AutoSize = true;
            this.Result_Label.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold);
            this.Result_Label.ForeColor = System.Drawing.Color.Red;
            this.Result_Label.Location = new System.Drawing.Point(47, 331);
            this.Result_Label.Name = "Result_Label";
            this.Result_Label.Size = new System.Drawing.Size(480, 27);
            this.Result_Label.TabIndex = 15;
            this.Result_Label.Text = "Lütfen tüm alanları doldurduğunuzdan emin olunuz.";
            this.Result_Label.Visible = false;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.BackColor = System.Drawing.Color.Red;
            this.Cancel_Button.Location = new System.Drawing.Point(364, 407);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(127, 58);
            this.Cancel_Button.TabIndex = 16;
            this.Cancel_Button.Text = "İptal";
            this.Cancel_Button.UseVisualStyleBackColor = false;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Result_Label);
            this.panel1.Controls.Add(this.adres_text);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.email_text);
            this.panel1.Controls.Add(this.tel_text);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.sifre_text);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tc_no_text);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ad_soyad_text);
            this.panel1.Location = new System.Drawing.Point(65, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 378);
            this.panel1.TabIndex = 17;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(689, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.SignUp_Button);
            this.Name = "SignUp";
            this.Text = "Sign Up Page";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ad_soyad_text;
        private System.Windows.Forms.TextBox tc_no_text;
        private System.Windows.Forms.TextBox sifre_text;
        private System.Windows.Forms.TextBox tel_text;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adres_text;
        private System.Windows.Forms.Button SignUp_Button;
        private System.Windows.Forms.Label Result_Label;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Panel panel1;
    }
}