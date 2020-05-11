using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            int data = head.val;
            while (head.next != null)
            {
                if (head.next.val == data)
                {
                    return true;
                }
                head.next = head.next.next;
            }
            return false;

        }
    }
}
