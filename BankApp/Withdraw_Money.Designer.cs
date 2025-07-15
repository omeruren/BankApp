namespace BankApp
{
    partial class Withdraw_Money
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
            this.label1 = new System.Windows.Forms.Label();
            this.amount_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Submit_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Result_label = new System.Windows.Forms.Label();
            this.account_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(35, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Heap no : ";
            // 
            // amount_text
            // 
            this.amount_text.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.amount_text.Location = new System.Drawing.Point(181, 89);
            this.amount_text.Name = "amount_text";
            this.amount_text.Size = new System.Drawing.Size(138, 30);
            this.amount_text.TabIndex = 1;
            this.amount_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amount_text_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(63, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tutar : ";
            // 
            // Submit_Button
            // 
            this.Submit_Button.Location = new System.Drawing.Point(52, 196);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(122, 69);
            this.Submit_Button.TabIndex = 3;
            this.Submit_Button.Text = "Onayla";
            this.Submit_Button.UseVisualStyleBackColor = true;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(220, 196);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(122, 69);
            this.Cancel_Button.TabIndex = 4;
            this.Cancel_Button.Text = "İptal";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Result_label
            // 
            this.Result_label.AutoSize = true;
            this.Result_label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Result_label.Location = new System.Drawing.Point(63, 148);
            this.Result_label.Name = "Result_label";
            this.Result_label.Size = new System.Drawing.Size(0, 24);
            this.Result_label.TabIndex = 5;
            this.Result_label.Visible = false;
            // 
            // account_label
            // 
            this.account_label.AutoSize = true;
            this.account_label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.account_label.Location = new System.Drawing.Point(177, 50);
            this.account_label.Name = "account_label";
            this.account_label.Size = new System.Drawing.Size(0, 24);
            this.account_label.TabIndex = 6;
            // 
            // Withdraw_Money
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 303);
            this.Controls.Add(this.account_label);
            this.Controls.Add(this.Result_label);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Submit_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amount_text);
            this.Controls.Add(this.label1);
            this.Name = "Withdraw_Money";
            this.Text = "Withdraw_Money";
            this.Load += new System.EventHandler(this.Withdraw_Money_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amount_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Label Result_label;
        private System.Windows.Forms.Label account_label;
    }
}