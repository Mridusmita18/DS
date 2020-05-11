using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public static class P3
    {
        public static void Reverse()
        {
            Console.WriteLine("Please enter the line");
            string s = Console.ReadLine();
            string newline = String.Empty;
            if (s != string.Empty)
            {
                string[] splitstring = s.Split(' ');
                for (int i = splitstring.Length - 1; i >= 0; i--)
                {
                    char[] arr = new char[splitstring[i].Length];
                    arr = splitstring[i].ToCharArray();

                    string newstr = String.Empty;
                    for (int j = 0; j <= arr.Length - 1; j++)

                    {
                        newstr = newstr + arr[j].ToString();

                    }

                    newline = newline + " " + newstr;
                }


                 Console.WriteLine(newline);
            }
            else Console.WriteLine("You didn't enter anything");
        }
    }
}
