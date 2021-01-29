using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheBank
{
    class CheckingAccount:TheBank.BankAccount
    {
        public CheckingAccount(string owner)
            : base(owner)
        {
            
        }
        override public decimal Withdraw(decimal amount)
        {
            base.Withdraw(amount);
            base.Withdraw(0.25M);
            return this.Balance;
        }
        public override string ID
        {
            get
            {
                return this.m_owner+"-C";
            }
        }
    }
}
