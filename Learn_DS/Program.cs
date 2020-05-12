using System;

namespace Learn_DS
{
    class Program
    {
        static void Main(string[] args)
        {
            Node first = new Node{ Value = 10 };
            Node second = new Node { Value = 50 };
            Node third = new Node { Value = 100 };
            first.Next = second;
            second.Next = third;

            //IEnumerator_IEnumerable.GetItems();

            //Print(first);

        }

        public static void Print(Node node)
        {
            while(node!=null)
            {
                Console.WriteLine($"Value is : {node.Value}");
                node = node.Next;
            }

        }
    }
}
