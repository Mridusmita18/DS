using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class P2
    {
        public static void Search()

        {
            Console.WriteLine("Please enter the size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter number {0}", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

    }
}
