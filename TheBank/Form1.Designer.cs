namespace TheBank
{
    partial class Form1
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
            this.account = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.action = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account";
            // 
            // account
            // 
            this.account.FormattingEnabled = true;
            this.account.Location = new System.Drawing.Point(106, 36);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(229, 21);
            this.account.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Transaction";
            // 
            // action
            // 
            this.action.FormattingEnabled = true;
            this.action.Items.AddRange(new object[] {
            "Deposit",
            "Withdraw"});
            this.action.Location = new System.Drawing.Point(106, 91);
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(229, 21);
            this.action.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount";
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(106, 138);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(229, 20);
            this.amount.TabIndex = 5;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(12, 181);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 211);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.action);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.account);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "The Bank";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox account;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox action;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Button submit;
    }
}

