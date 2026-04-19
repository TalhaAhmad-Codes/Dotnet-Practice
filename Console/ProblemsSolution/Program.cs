using ProblemsSolution.Problem_5;

namespace ProblemsSolution
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
