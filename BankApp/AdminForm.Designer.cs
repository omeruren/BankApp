namespace BankApp
{
    partial class AdminForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ListAccounts_Buttton = new System.Windows.Forms.Button();
            this.NewAccount_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NewUser_Button = new System.Windows.Forms.Button();
            this.ListUsers_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RemittanceHistory_Button = new System.Windows.Forms.Button();
            this.ListTransactions_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AccCount_Label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UserCount_Label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BankBalance_Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListAccounts_Buttton
            // 
            this.ListAccounts_Buttton.Location = new System.Drawing.Point(6, 37);
            this.ListAccounts_Buttton.Name = "ListAccounts_Buttton";
            this.ListAccounts_Buttton.Size = new System.Drawing.Size(130, 64);
            this.ListAccounts_Buttton.TabIndex = 0;
            this.ListAccounts_Buttton.Text = "Hesap İşlemleri";
            this.ListAccounts_Buttton.UseVisualStyleBackColor = true;
            this.ListAccounts_Buttton.Click += new System.EventHandler(this.ListAccounts_Buttton_Click);
            // 
            // NewAccount_Button
            // 
            this.NewAccount_Button.Location = new System.Drawing.Point(158, 37);
            this.NewAccount_Button.Name = "NewAccount_Button";
            this.NewAccount_Button.Size = new System.Drawing.Size(130, 64);
            this.NewAccount_Button.TabIndex = 1;
            this.NewAccount_Button.Text = "Yeni Hesap Oluştur";
            this.NewAccount_Button.UseVisualStyleBackColor = true;
            this.NewAccount_Button.Click += new System.EventHandler(this.NewAccount_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NewUser_Button);
            this.groupBox1.Controls.Add(this.ListUsers_Button);
            this.groupBox1.Location = new System.Drawing.Point(33, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // NewUser_Button
            // 
            this.NewUser_Button.Location = new System.Drawing.Point(158, 37);
            this.NewUser_Button.Name = "NewUser_Button";
            this.NewUser_Button.Size = new System.Drawing.Size(130, 64);
            this.NewUser_Button.TabIndex = 1;
            this.NewUser_Button.Text = "Yeni Kullanıcı Oluştur";
            this.NewUser_Button.UseVisualStyleBackColor = true;
            this.NewUser_Button.Click += new System.EventHandler(this.NewUser_Button_Click);
            // 
            // ListUsers_Button
            // 
            this.ListUsers_Button.Location = new System.Drawing.Point(6, 37);
            this.ListUsers_Button.Name = "ListUsers_Button";
            this.ListUsers_Button.Size = new System.Drawing.Size(130, 64);
            this.ListUsers_Button.TabIndex = 0;
            this.ListUsers_Button.Text = "Kullanıcı İşlemleri";
            this.ListUsers_Button.UseVisualStyleBackColor = true;
            this.ListUsers_Button.Click += new System.EventHandler(this.ListUsers_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Yönetimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 564);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hesap Yönetimi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListAccounts_Buttton);
            this.groupBox2.Controls.Add(this.NewAccount_Button);
            this.groupBox2.Location = new System.Drawing.Point(43, 591);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 158);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(35, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Banka İşlemleri Yönetimi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RemittanceHistory_Button);
            this.groupBox3.Controls.Add(this.ListTransactions_Button);
            this.groupBox3.Location = new System.Drawing.Point(39, 359);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 158);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // RemittanceHistory_Button
            // 
            this.RemittanceHistory_Button.Location = new System.Drawing.Point(158, 37);
            this.RemittanceHistory_Button.Name = "RemittanceHistory_Button";
            this.RemittanceHistory_Button.Size = new System.Drawing.Size(130, 64);
            this.RemittanceHistory_Button.TabIndex = 2;
            this.RemittanceHistory_Button.Text = "Havale İşlemleri";
            this.RemittanceHistory_Button.UseVisualStyleBackColor = true;
            this.RemittanceHistory_Button.Click += new System.EventHandler(this.RemittanceHistory_Button_Click);
            // 
            // ListTransactions_Button
            // 
            this.ListTransactions_Button.Location = new System.Drawing.Point(6, 37);
            this.ListTransactions_Button.Name = "ListTransactions_Button";
            this.ListTransactions_Button.Size = new System.Drawing.Size(130, 64);
            this.ListTransactions_Button.TabIndex = 0;
            this.ListTransactions_Button.Text = "Banka İşlemleri";
            this.ListTransactions_Button.UseVisualStyleBackColor = true;
            this.ListTransactions_Button.Click += new System.EventHandler(this.ListTransactions_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(341, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Banka Verileri";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chart2);
            this.groupBox4.Controls.Add(this.chart1);
            this.groupBox4.Controls.Add(this.AccCount_Label);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.UserCount_Label);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.BankBalance_Label);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(345, 100);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1099, 652);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.DarkGray;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(12, 230);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(515, 416);
            this.chart2.TabIndex = 17;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.DarkGray;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(533, 230);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(515, 416);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // AccCount_Label
            // 
            this.AccCount_Label.AutoSize = true;
            this.AccCount_Label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AccCount_Label.Location = new System.Drawing.Point(207, 151);
            this.AccCount_Label.Name = "AccCount_Label";
            this.AccCount_Label.Size = new System.Drawing.Size(0, 24);
            this.AccCount_Label.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(29, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Hesap Sayısı :";
            // 
            // UserCount_Label
            // 
            this.UserCount_Label.AutoSize = true;
            this.UserCount_Label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserCount_Label.Location = new System.Drawing.Point(207, 103);
            this.UserCount_Label.Name = "UserCount_Label";
            this.UserCount_Label.Size = new System.Drawing.Size(0, 24);
            this.UserCount_Label.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(8, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kullanıcı Sayısı :";
            // 
            // BankBalance_Label
            // 
            this.BankBalance_Label.AutoSize = true;
            this.BankBalance_Label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BankBalance_Label.Location = new System.Drawing.Point(207, 55);
            this.BankBalance_Label.Name = "BankBalance_Label";
            this.BankBalance_Label.Size = new System.Drawing.Size(0, 24);
            this.BankBalance_Label.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Banka Hazinesi :";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 880);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminForm";
            this.Text = "Admin Page";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ListAccounts_Buttton;
        private System.Windows.Forms.Button NewAccount_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button NewUser_Button;
        private System.Windows.Forms.Button ListUsers_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ListTransactions_Button;
        private System.Windows.Forms.Button RemittanceHistory_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label BankBalance_Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AccCount_Label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label UserCount_Label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}