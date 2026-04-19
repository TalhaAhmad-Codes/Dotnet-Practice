
---

# Problem Statement

Grade Calculator  
- Create a `Subject` class with `name` and `marks` using getters/setters
- Ask the user how many subjects they have using I/O
- Loop to input each subject name + marks
- Function `GetGrade(int marks)` uses conditionals to return A/B/C/F
- Print each subject with its grade

---

# Solution

## Subject Class

```cs
namespace Project
{
    public class Subject
    {
        public string Name { get; set; }
        public int Marks { get; set; }

        public Subject(string name, int marks)
        {
            Name = name;
            Marks = marks;
        }

        public static char GetGrade(int marks)
        {
            return marks switch {
                >= 80 => 'A',
                >= 60 => 'B',
                >= 40 => 'C',
                _ => 'F'
            };
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
            List<Subject> subjects = [];

            // Get subjects from user
            while (true)
            {
                Console.Write("\nEnter name of the subject: ");
                var name = Console.ReadLine()!;

                // Condition to quit
                if (name.Length == 0)
                {
                    break;
                }

                Console.Write("Enter marks of the subject: ");
                var marks = int.Parse(Console.ReadLine()!);

                subjects.Add(new(name, marks));
            }

            // Print all subjects with grades
            foreach (var subject in subjects)
            {
                Console.WriteLine($"\nName: {subject.Name}");
                Console.WriteLine($"Makes: {subject.Marks}");
                Console.WriteLine($"Grade: {Subject.GetGrade(subject.Marks)}");
            }
        }
    }
}
```

---
