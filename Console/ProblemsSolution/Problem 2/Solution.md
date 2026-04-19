
---

# Problem Statement

Even/Odd Counter  
- Ask the user for a starting number and ending number
- Use a loop to check each number in that range
- Create a function `IsEven(int num)` that returns true/false
- Count how many evens and odds there are using conditionals
- Store the counts in a `Counter` class with getters/setters, then print results

---

# Solution

## Counter Class

```cs
namespace Project
{
    public class Counter
    {
        public static int EvenCount { get; set; } = 0;
        public static int OddCount { get; set; } = 0;
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
            // Take input
            Console.Write("Enter starting number: ");
            int startNumber = int.Parse(Console.ReadLine()!);

            Console.Write("Enter ending number: ");
            int endNumber = int.Parse(Console.ReadLine()!);

            // Count and check in given range
            for (int i = startNumber; i <= endNumber; i++)
            {
                if (IsEven(i))
                {
                    Counter.EvenCount++;
                }
                else
                {
                    Counter.OddCount++;
                }
            }

            // Display the result
            Console.WriteLine($"Even numbers are {Counter.EvenCount} and Odd numbers are {Counter.OddCount}.");
        }

        public static bool IsEven(int number)
            => number % 2 == 0;
    }
}
```

---
