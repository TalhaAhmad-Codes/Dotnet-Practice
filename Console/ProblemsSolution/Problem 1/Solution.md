
---

# Problem Statement

Write a program that:
- Uses variables to store a student's `name`, `age`, and `GPA`
- Takes the values from user input with I/O
- Creates a `Student` class with getters/setters for those fields
- Has a function `DisplayInfo()` that prints everything  
> **Bonus:** Use a conditional to print "Honor Roll" if GPA >= 3.5

---

# Solution

## Student Class

```cs
namespace Project
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public float GPA { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name:   {Name}");
            Console.WriteLine($"Age:    {Age}");
            Console.WriteLine($"GPA:    {GPA}");

            if (GPA >= 3.50)
            {
                Console.WriteLine("Honor Roll");
            }
        }
    }
}
```

## Main File

```cs
using Project;

Student student = new();

student.Name = "Talha Ahmad";
student.Age = 20;
student.GPA = 2.9f;

student.DisplayInfo();
```

---
