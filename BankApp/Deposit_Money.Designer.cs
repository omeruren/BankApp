namespace BankApp
{
    partial class Deposit_Money
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
            this.account_label = new System.Windows.Forms.Label();
            this.Result_Label = new System.Windows.Forms.Label();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Submit_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.amount_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // account_label
            // 
            this.account_label.AutoSize = true;
            this.account_label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.account_label.Location = new System.Drawing.Point(166, 50);
            this.account_label.Name = "account_label";
            this.account_label.Size = new System.Drawing.Size(0, 24);
            this.account_label.TabIndex = 13;
            // 
            // Result_Label
            // 
            this.Result_Label.AutoSize = true;
            this.Result_Label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Result_Label.Location = new System.Drawing.Point(76, 145);
            this.Result_Label.Name = "Result_Label";
            this.Result_Label.Size = new System.Drawing.Size(0, 24);
            this.Result_Label.TabIndex = 12;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(243, 193);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(122, 69);
            this.Cancel_Button.TabIndex = 11;
            this.Cancel_Button.Text = "İptal";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Submit_Button
            // 
            this.Submit_Button.Location = new System.Drawing.Point(52, 193);
            this.Submit_Button.Name = "Submit_Button";
            this.Submit_Button.Size = new System.Drawing.Size(122, 69);
            this.Submit_Button.TabIndex = 10;
            this.Submit_Button.Text = "Onayla";
            this.Submit_Button.UseVisualStyleBackColor = true;
            this.Submit_Button.Click += new System.EventHandler(this.Submit_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(76, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tutar : ";
            // 
            // amount_text
            // 
            this.amount_text.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.amount_text.Location = new System.Drawing.Point(170, 89);
            this.amount_text.Name = "amount_text";
            this.amount_text.Size = new System.Drawing.Size(136, 30);
            this.amount_text.TabIndex = 8;
            this.amount_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amount_text_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(48, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Heap no : ";
            // 
            // Deposit_Money
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 303);
            this.Controls.Add(this.account_label);
            this.Controls.Add(this.Result_Label);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Submit_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amount_text);
            this.Controls.Add(this.label1);
            this.Name = "Deposit_Money";
            this.Text = "Deposit Money Page";
            this.Load += new System.EventHandler(this.Deposit_Money_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label account_label;
        private System.Windows.Forms.Label Result_Label;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Submit_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amount_text;
        private System.Windows.Forms.Label label1;
    }
}