namespace BankAppinheritance
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public double Balance { get; private set; }

        public Account(int accountNumber)
        {
            AccountNumber = accountNumber;
        }

        public Account()
        {
        }

        public virtual bool Deposite(double amount)
        {
            Balance += amount;
            return true;
        }
        public virtual bool Withdraw(double amount)
        {
            Balance -= amount;
            return true;
        }

      
    }
}