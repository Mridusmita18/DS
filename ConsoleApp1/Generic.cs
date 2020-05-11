using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Generic<T>
    {

        public T Calculate<T>(T T1, T T2)
        {

          
            dynamic a = T1;
            dynamic b = T2;
            return a + b;

          

        }
        public int Calculate(int i, int j)
        {
           
            return i + j;



        }

        public void GetHashTable()
        {

        Hashtable obj1= new Hashtable()
        {
            {1,1},
            {1,2 }
        };


        }
    }
}
