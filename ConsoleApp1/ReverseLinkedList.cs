using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class ReverseLinkedList
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode current = l1, prev = null, next = null;
            ListNode currentl2 = l2, prevl2 = null, nextl2 = null;
            ListNode nextnewNode = null;
            double reversel1 = 0, reversel2 = 0;
            int countl1 = -1, countl2 = -1;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
                countl1++;
            }
            while (prev != null)
            {
                reversel1 = reversel1 + prev.val * Math.Pow(10, countl1);
                prev = prev.next;
                countl1--;
            }
            while (currentl2!= null)
            {
                nextl2 = currentl2.next;
                currentl2.next = prevl2;
                prevl2 = currentl2;
                currentl2 = nextl2;
                countl2++;
            }
            while (prevl2 != null)
            {
                reversel2 = reversel2 + prevl2.val * Math.Pow(10, countl2);
                prevl2 = prevl2.next;
                countl2--;
            }
            double final = reversel1 + reversel2;
            string s = final.ToString();
            for (int i =0; i<s.Length; i++)
            {
                int val = (int)Char.GetNumericValue(s[i]);
                ListNode newNode = new ListNode(val);
                newNode.next = nextnewNode;
                nextnewNode = newNode;
            }


          
            return nextnewNode;

        }

        public static ListNode Add(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            ListNode newNode = null;
            int d = 0,rem=0;
            while (l1 != null || l2 != null)
            {
                if (l1 != null && l2 != null)
                {
                    d = l1.val + l2.val+rem;
                }
                else if (l1 != null) d = l1.val+rem;
                else d = l2.val+rem;

                if (d > 9)
                {
                    rem = 1;
                    d = d - 10;
                }
                else rem = 0;

                ListNode node=new ListNode(d);
                node.next = newNode;
                newNode = node;
                l1 = l1.next;
                l2 = l2.next;
                if (l1 == null && l2 == null)
                {
                    ListNode remnode = new ListNode(rem);
                    remnode.next = newNode;
                    newNode = remnode;

                }
            }
            ListNode current = newNode, prev = null, next = null;
            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            return prev;
        }
    }
}

