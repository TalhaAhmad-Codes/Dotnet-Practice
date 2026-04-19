namespace ProblemsSolution.Problem_3
{
    public class BankAccount
    {
        private double balance;
        public double Balance
        {
            get => balance;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Balance can't be negative!");
                }

                balance = value;
            }
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new Exception("You must enter some amount to deposit!");
            }

            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance - amount < 0)
            {
                throw new Exception("Insufficient Balance!");
            }

            Balance -= amount;
        }
    }
}
