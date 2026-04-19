namespace ProblemsSolution.Problem_1
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
