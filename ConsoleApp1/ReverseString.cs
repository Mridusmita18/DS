using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ReverseString
    {
        public void GetElement()
        {
            string s = Console.ReadLine();
            bool found = false;
            string[] sarray = s.Split(' ');
            int arrsize = Convert.ToInt32(sarray[0]);
            int find = Convert.ToInt32(sarray[1]);
            string array = Console.ReadLine();
            string[] arraylist = array.Split(' ');
            int[] arr = new int[arraylist.Length];
            for (int i = 0; i <= arraylist.Length - 1; i++)
            {
                arr[i] = Convert.ToInt32(arraylist[i]);
            }
            int j = getIndex(arr, 0, arr.Length - 1, find);
            Console.WriteLine("Element found at position {0}", j);
            Console.ReadKey();

        }

      
        public int getIndex(int[] arr, int start, int end, int find)
        {
            if (start <= end)
            {
                int mid = (start + end) / 2;
                if (find < arr[mid])
                {
                    return getIndex(arr, start, mid - 1, find);
                }
                else if (find > arr[mid])
                {
                    return getIndex(arr, mid + 1, end, find);
                }
                else if (arr[mid] == find)
                {
                    return mid;
                }

                return -1;
            }

            return -1;
        }

      
        }
    }


