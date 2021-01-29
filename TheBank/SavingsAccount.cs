using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheBank
{
    class SavingsAccount:TheBank.BankAccount
    {
        private decimal m_interest = 0.01M;

        public SavingsAccount(string owner ):base (owner)
        {}
        virtual public string ID
        {
            get { return this.m_owner + "-S"; }
        }

        public decimal Interest
        {
            get { return m_interest; }
            set { m_interest = value; }
        }

        public decimal AddInterest()
        {
            this.Deposit(m_interest * this.Balance);
            return this.Balance;
        }
    }
}
