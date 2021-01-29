using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheBank
{
    class BankAccount
    {
        protected string m_owner;
        private decimal m_balance;

        public BankAccount(string owner)
        {
            m_owner = owner;
            m_balance = 0M;
        }
        
        virtual public string ID
        {
            get { return m_owner; }
        }
        public decimal Balance
        {
            get { return m_balance; }
        }

        //metode

        public decimal Deposit(decimal amount)
        {
            m_balance += amount;
            return m_balance;
        }

        virtual public decimal Withdraw(decimal amount)
        {
            return (m_balance-=amount);
        }
    }
}
