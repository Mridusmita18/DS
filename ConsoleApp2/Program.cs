using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int grade = 0;
            //Console.WriteLine(grade);
            //GiveCredit(grade);
            //Console.WriteLine(grade);

            string grade = "Hello";
            Console.WriteLine(grade);
            GiveCredit(grade);
            Console.WriteLine(grade);

            int[] grades=new int[]{1,2};
            Console.WriteLine(grades[0]);
            GiveCredit(grades);
            Console.WriteLine(grades[0]);

            Console.ReadKey();
        }

        public static void GiveCredit(int g)
        {
            g++;
        }
        public static void GiveCredit(int[] g)
        {
            g[0]=3;
        }
        public static void GiveCredit(string g)
        {
            g = "Hello World";
        }
    }
}
