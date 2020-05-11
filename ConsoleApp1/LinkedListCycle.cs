using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class LinkedListCycle
    {
        public void CreateList()
        {
            LinkedlList l = new LinkedlList();
            {
                l.headNode = new LinkedlList.Node(3);
            }
        }
        
        ListNode secondNode = new ListNode(2);
        ListNode thirdNode = new ListNode(0);
        ListNode lastNode = new ListNode(-4);
      

        public  bool HasCycle(ListNode head)
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
