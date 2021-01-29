using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheBank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private CheckingAccount checking = new CheckingAccount("Aleksandar");
        private SavingsAccount savings = new SavingsAccount("Aleksandar");         
        private void Form1_Load(object sender, EventArgs e)
        {
               
            this.account.Items.Add(checking);
            this.account.Items.Add(savings);
            this.account.SelectedIndex=0;
            this.action.SelectedIndex=0;
            this.amount.Text="100";
        }

        private void submit_Click(object sender, EventArgs e)
        {
            BankAccount selectedAccount;
            object item = this.account.SelectedIndex;
            selectedAccount =(BankAccount)item;
            switch (action.Text)
            {
                case "Deposit":
                    selectedAccount.Deposit(decimal.Parse(amount.Text));
                    break;

                case "Withdraw":
                    selectedAccount.Withdraw(decimal.Parse(amount.Text));
                    break;
            }
            MessageBox.Show(String.Format("{0}: {1:C}",selectedAccount.ID,selectedAccount.Balance));
        }
    }
}
