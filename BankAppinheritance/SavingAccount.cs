namespace BankAppinheritance
{
    public class SavingAccount:Account
    {
        public double InterestRate { get; set; }

        public SavingAccount(int accountNumber, double interestRate) : base(accountNumber)
        {
            InterestRate = interestRate;
        }

        public SavingAccount()
        {
        }

        public override bool Withdraw(double amount)
        {
            if (Balance - amount >= 1000)
            {
               
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