namespace ProblemsSolution.Problem_4
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
