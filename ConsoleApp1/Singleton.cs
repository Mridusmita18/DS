using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  sealed class Singleton
    {
        private static Singleton _instance;
        private static readonly object _lock=new object();
        private int counter = 0;
        private Singleton()
        {
            counter++;
            Console.WriteLine("{0}",counter);
        }

        public static Singleton GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new Singleton();
                    }
                }

                return _instance;
            }
        }
    }
}
