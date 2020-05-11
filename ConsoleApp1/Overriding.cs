using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am in base class");
        }

    }
    public class DerivedClass: BaseClass
    {

        public  void  Print()
        {
            Console.WriteLine("I am in derived class");
        }

    }
}
