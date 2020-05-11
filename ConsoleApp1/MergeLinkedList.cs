using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class MergeLinkedList
    {
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode start = null,newnode=null;
            if (l1 == null)
                return l2;
            if (l2 == null) return l1;
         
            if (l1.val <= l2.val)
            {
                start = l1;
                l1 = l1.next;
            }
            else
            {
                    start = l2;
                    l2 = l2.next;
            }

            newnode = start;

            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    start.next = l1;
                    start = l1;
                    l1 = start.next;
                }
                else
                {
                    start.next = l2;
                    start = l2;
                    l2 = start.next;
                }
            }

            if (l1 == null) start.next = l2;
            if (l2 == null) start.next = l1;
            return newnode;
        }
    }
}
