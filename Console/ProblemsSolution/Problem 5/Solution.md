
---

# Problem Statement

Password Retry System  
- Store correct password in a variable
- Use a loop to give the user 3 attempts via I/O
- Create a `User` class with `username` and `password` + getters/setters
- Function `CheckPassword(string input)` uses conditionals to compare
- If correct, print "Access Granted". If 3 fails, print "Locked Out"

---

# Solution

## User Class

```cs
namespace Project
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public bool CheckPassword(string input)
            => Password == input;
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
            User user = new()
            {
                Username = "Talha Ahmad",
                Password = "12345678"
            };
            bool succeed = false;

            for (int i = 1; i <= 3; i++)
            {
                // Take input
                Console.Write($"Enter Password (Attempt {i}): ");
                string password = Console.ReadLine()!;

                // Check password
                if (user.CheckPassword(password))
                {
                    Console.WriteLine("Access Granted");
                    succeed = true;
                    break;
                }
            }

            // All attempts are failed
            if (!succeed)
            {
                Console.WriteLine("Locked Out");
            }
        }
    }
}
```

---
