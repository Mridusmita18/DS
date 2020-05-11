using System;

namespace Learn_DS
{
    class Program
    {
        static string Main(string[] args)
        {
            Node first = new Node{ Value = 10 };
            Node second = new Node { Value = 50 };
            first.Next = second;

           

            Console.WriteLine("Hello World!");
            return "Hello";
        }

        public static void Print(Node node)
        {

        }
    }
}
