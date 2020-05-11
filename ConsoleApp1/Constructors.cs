using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// 
    /// </summary>
   public class Constructors
    {
        public Constructors()
        {
            Console.WriteLine("I am in constructor");
            ArrayList obj=new ArrayList();
            List<int> objList=new List<int>();
          

        }
        public Constructors(string s)
        {
            Console.WriteLine("I am in parameterized constructor");

        }
        //static Constructors()
        //{
        //    Console.WriteLine("I am in static constructor");

        //}

    }

    /// <summary>
    /// 
    /// </summary>
    ///
    ///
    /// 
    public class ChildConstructors: Constructors
    {
        public ChildConstructors()//: base()
        {
            Console.WriteLine("I am in child constructor");

        }
        public ChildConstructors(string s): base("Hello")
        {
            Console.WriteLine("I am in child parameterized constructor");

        }
        //static ChildConstructors()
        //{
        //    Console.WriteLine("I am in child static constructor");

        //}
    }
    public static class StaticConstructors 
    {
        static StaticConstructors()
        {
            Console.WriteLine("I am in static constructor");

        }
    }
}
