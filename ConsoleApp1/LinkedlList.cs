using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  public  class LinkedlList
  {
       public Node headNode;
        public class Node
        {
            public int _data;
            public Node next;
            public Node(int d)
            {
                _data = d;
                next = null;

            }
        }
    }
}
