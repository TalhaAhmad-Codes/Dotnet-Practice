
---

# Problem Statement
 
Make a `BankAccount` class with:
- Private variable `balance` with getter/setter
- Function `Deposit(double amount)` and `Withdraw(double amount)`
- Use conditionals so `Withdraw` can’t go below 0
- In `Main`, use I/O to let the user deposit/withdraw in a loop until they type "exit"
- After each action, print the new balance

---

# Solution

## Bank Account Class

```cs
namespace Project
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
```

## Main File

```cs
namespace Project
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BankAccount account = new();
            int choice;
            double amount;

            do
            {
                // Get action choice
                Console.Write("1-Deposit, 2-Withdraw, 3-Exit: ");
                choice = int.Parse(Console.ReadLine()!);

                try
                {
                    // Perform action
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter amount: ");
                            amount = Convert.ToDouble(Console.ReadLine()!);
                            account.Deposit(amount);
                            break;

                        case 2:
                            Console.Write("Enter amount: ");
                            amount = Convert.ToDouble(Console.ReadLine()!);
                            account.Withdraw(amount);
                            break;

                        case 3:
                            Console.WriteLine("Quiting...");
                            break;

                        default:
                            throw new Exception("Incorrect choice!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine($"Current Balance: {account.Balance}\n");
                }
            }
            while (choice != 3);
        }
    }
}
```

---
