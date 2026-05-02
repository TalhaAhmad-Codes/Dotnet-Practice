namespace HardSorting
{
    public class Node
    {
        public int Value { get; init; }
        public Node? Next { get; set; } = null;
        public Node? Previous { get; set; } = null;
    }

    public class LinkedList
    {
        // Properties
        public int Count { get; private set; } = 0;
        public Node? Head { get; private set; }
        public Node? Tail { get; private set; }

        // Constructor
        public LinkedList(Node? head = null, Node? tail = null)
        {
            Head = head;
            Tail = tail;
        }

        /* Methods - Manipulation of the list */

        // Add a new node to the start of the list
        public void AddStart(int value)
        {
            Node newNode = new() { Value = value };

            if (Head == null)
            {
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head.Previous = null;
            }

            Head = newNode;
            IncreaseCount();
        }

        // Add a new node to the end of the list
        public void AddEnd(int value)
        {
            Node newNode = new() { Value = value };

            if (Tail == null)
            {
                Head = newNode;
            }
            else
            {
                newNode.Previous = Tail;
                Tail.Next = newNode;
            }

            Tail = newNode;
            IncreaseCount();
        }

        // Remove a node form start of the list
        public void RemoveStart()
        {
            if (Head == null) return;

            if (Head.Next == null)
            {
                Tail = null;
            }
            else
            {
                Head.Next.Previous = null;
            }

            Head = Head.Next;
            DecreaseCount();
        }

        // Remove a node form end of the list
        public void RemoveEnd()
        {
            if (Tail == null) return;

            if (Tail.Previous == null)
            {
                Head = null;
            }
            else
            {
                Tail.Previous.Next = null;
            }

            Tail = Tail.Previous;
            DecreaseCount();
        }

        // Add a node at specific index
        public void AddAt(int index, int value)
        {
            if (index < 0 || index >= Count) throw new ArgumentOutOfRangeException(nameof(index));

            if (index == 0)
            {
                AddStart(value);
                return;
            }

            if (index == Count)
            {
                AddEnd(value);
                return;
            }

            Node newNode = new() { Value = value };
            Node current = Head!;

            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next!;
            }

            newNode.Next = current.Next;
            newNode.Previous = current;
            current.Next!.Previous = newNode;
            current.Next = newNode;

            IncreaseCount();
        }

        // Remove a node at specific index
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count) throw new ArgumentOutOfRangeException(nameof(index));

            if (index == 0)
            {
                RemoveStart();
                return;
            }

            if (index == Count - 1)
            {
                RemoveEnd();
                return;
            }

            Node current = Head!;

            for (int i = 0; i < index; i++)
            {
                current = current.Next!;
            }

            current.Previous!.Next = current.Next;
            current.Next!.Previous = current.Previous;

            DecreaseCount();
        }

        // Get node at specific index
        public Node? GetAt(int index)
        {
            if (index < 0 || index >= Count) throw new ArgumentOutOfRangeException(nameof(index));

            var current = Head;

            if (current is null) return null;

            for (int i = 0; i < index; i++)
            {
                current = current.Next!;
            }

            return current;
        }

        /* Misc. Methods */

        // Update the count
        void IncreaseCount() => Count++;
        void DecreaseCount() => Count--;

        // Display the list
        public void Display()
        {
            Node? current = Head;

            while (current != null)
            {
                Console.Write($"{current.Value} ");
                current = current.Next;
            }

            Console.WriteLine();
        }

        // Check if a node is head or not
        public static bool IsHead(Node node, LinkedList list) => node == list.Head;

        // Check if a node is tail or not
        public static bool IsTail(Node node, LinkedList list) => node == list.Tail;

        // Swap two nodes in the list
        public static void Swap(Node node1, Node node2, LinkedList list)
        {
            if (node1 == node2) return;

            // Swap the values of the nodes
            var temp = node1;

            
        }
    }
}
