using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public class Count
    {
        public void Count0()
        {
            int size = Convert.ToInt32(Console.ReadLine());
            string array = Console.ReadLine();
            string[] arraylist = array.Split(' ');
            int[] arr = new int[arraylist.Length];
            int count = 0;
            for (int i = 0; i <= arraylist.Length - 1; i++)
            {
                arr[i] = Convert.ToInt32(arraylist[i]);
                if (arr[i] == 0)
                    count++;
            }
            for (int i = arr.Length-1; i >=(arr.Length - count); i--)
            {
                arr[i] = 0;
            }
            for (int i = 0; i<count-1; i++)
            {
                arr[i] = 1;
            }
            for (int i = 0; i <= arr.Length - 1; i++)
            {
               Console.Write("{0}",arr[i]);
            }


        }
    }
}
