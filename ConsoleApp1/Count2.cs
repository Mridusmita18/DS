using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Count2
    {
        public void Count()
        {
            int size = Convert.ToInt32(Console.ReadLine());
            string array = Console.ReadLine();
            string[] arraylist = array.Split(' ');
            int[] arr = new int[arraylist.Length];
            for (int i = 0; i <= arraylist.Length - 1; i++)
            {
                arr[i] = Convert.ToInt32(arraylist[i]);
            }

            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                if (arr[left] == 1)
                    left++;
                else arr[left] = 1;
                if (arr[right] == 1)
                {
                    arr[right] = 0;
                    right--;
                }
            }
            for (int i = 0; i <= arraylist.Length - 1; i++)
            {
                Console.Write("{0} ",arr[i]);// = Convert.ToInt32(arraylist[i]));
            }
        }
    }
}
