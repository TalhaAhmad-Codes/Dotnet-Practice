namespace HardSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new();

            list.AddStart(3);
            list.AddStart(2);
            list.AddStart(1);
            list.AddEnd(4);
            list.AddEnd(5);
            list.AddEnd(6);

            list.Display();
            Console.WriteLine($"Total: {list.Count}");
        }
    }
}
