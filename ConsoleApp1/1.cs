using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class P1
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

        bool found = false;
        Console.WriteLine("Please enter the number to be searched");
        int no = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= arr.Length - 1; i++)
        {
            if (no == arr[i])
            {
                found = true;
                Console.WriteLine("Number found at position {0}", i);
                break;
            }
        }

        if (found == false)
            Console.WriteLine("Number not found");
    }
}
}


    

