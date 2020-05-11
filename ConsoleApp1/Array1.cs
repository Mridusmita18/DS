using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Array1
    {
        public void Find()
        {
            int noofTC = Convert.ToInt32(Console.ReadLine());
            while (noofTC > 0)
            {
                noofTC--;
                string s = String.Empty;
                string strarray = String.Empty;
                s = Console.ReadLine();
                string[] sarr = s.Split(' ');
                int arrysize = Convert.ToInt32(sarr[0]);
                int d = Convert.ToInt32(sarr[1]);
                strarray = Console.ReadLine();
                string[] arr = strarray.Split(' ');
                int[] arry = new int[arrysize];
                for (int i = 0; i <= arry.Length - 1; i++)
                {
                    arry[i] = Convert.ToInt32(arr[i]); // Convert.ToInt32(Console.ReadLine());
                }

                int[] temparr = new int[d];
                for (int i = 0, j = 0; i <= d - 1; i++, j++)
                {
                    temparr[i] = arry[j];

                }

                for (int i = d, z = 0; i <= arrysize - 1; i++, z++)
                {
                    arry[z] = arry[i];

                }

                for (int j = temparr.Length - 1, z = arry.Length - 1; j >= 0; j--, z--)
                {
                    arry[z] = temparr[j];
                }

                for (int i = 0; i <= arry.Length - 1; i++)
                {

                    Console.Write("{0} ", arry[i]);


                }

                Console.WriteLine();
                Console.ReadKey();

            }
        }
    }
}
