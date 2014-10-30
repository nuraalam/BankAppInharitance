using System.Collections;
using System.Collections.Generic;

namespace BankAppinheritance
{
    internal class CheeckingAccount:Account
    {
        public double ServiceCharge { get; set; }
        public int NoOfTransaction { get; set; }

        public CheeckingAccount(int accountNumber, double serviceCharge) : base(accountNumber)
        {
            ServiceCharge = serviceCharge;
        }

        public CheeckingAccount()
        {
        }
        public override bool Withdraw(double amount)
        {
           
            if (Balance - amount >= 0)
            {
                NoOfTransaction++;
                //Use base class Withdraw method if condition is fulfilled
                return base.Withdraw(amount);
            }
            else
            {
                return false;
            }
            
        }
    }
}