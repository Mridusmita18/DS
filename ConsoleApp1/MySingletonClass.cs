using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MySingletonClass
    {
        private static MySingletonClass _instance=null;
        private static readonly object _synclock=new object();
        private MySingletonClass()
        {

        }

        public static MySingletonClass GetInstance
        {
            get
            {
                if (_instance==null)
                     _instance=new MySingletonClass();
                return _instance;
            }

        }

        
    }
}
