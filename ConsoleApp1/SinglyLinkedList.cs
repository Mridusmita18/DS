using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SinglyLinkedList
    {
        LinkedlList l = new LinkedlList();
        public void Create()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Select an activity:");
                Console.WriteLine("1. InsertAtLast:  2.Delete  3.Search: 4.InsertAtFirst ");
                int activity = Convert.ToInt32(Console.ReadLine());
                switch (activity)
                {
                    case 1:
                        InsertAtLast();
                        Display();
                        break;
                    case 2:
                        Delete();
                        Display();
                        break;
                    case 3:
                       Search();
                        break;
                    case 4:
                        InsertAtFirst();
                        Display();
                        break;
                    default:
                        Console.WriteLine("You did not select a correct activity");
                        break;

                }
            }
        }

        public void Display()
        {
            LinkedlList.Node n = l.headNode;
            if(n==null)
                Console.WriteLine("The list is empty");
            while (n != null)
            {
                Console.Write("{0}  ", n._data);
                 n = n.next;

            }
        }

        public LinkedlList.Node GetLastNode()
        {
            LinkedlList.Node n = l.headNode;
            while (n.next != null)
            {               
                n = n.next;

            }

            return n;

        }

        public void InsertAtLast()
        {
            LinkedlList.Node n = l.headNode;
            Console.WriteLine("Please enter the element to be inserted");
            int elem = Convert.ToInt32(Console.ReadLine());
            LinkedlList.Node newnode = new LinkedlList.Node(elem);
            if (n == null)
            {
                l.headNode = newnode;
            }
            else
            {            
                LinkedlList.Node lastnode = GetLastNode();             
                lastnode.next = newnode;
            }
           
        }
        public void InsertAtFirst()
        {
            LinkedlList.Node n = l.headNode;
            Console.WriteLine("Please enter the element to be inserted");
            int elem = Convert.ToInt32(Console.ReadLine());
            LinkedlList.Node newnode = new LinkedlList.Node(elem);
            if (n == null)
            {
                l.headNode = newnode;
            }
            else
            {
                newnode.next = n;
                l.headNode = newnode;
            }
        }

        public void Delete()
        {
            LinkedlList.Node n = l.headNode;
            if (n == null)
            {
                Console.WriteLine("The list is empty.");
            }
            else
            {
                Console.WriteLine("Please enter the element to be deleted");
                int elem = Convert.ToInt32(Console.ReadLine());
                LinkedlList.Node next=null;
                LinkedlList.Node prev = null;
                if (n != null && n._data == elem)
                    l.headNode = n.next;

                int d = 2 ^ 10;
              
                while (n.next != null)
                {
                    if (n.next._data== elem)
                    {
                        prev = n;                       
                    }
                    if (n._data == elem)
                    {
                        next = n.next;
                    }

                    n = n.next;
                }
                if(prev!=null)
                prev.next = next;
            }
        }

        public void Search()
        {
            LinkedlList.Node n = l.headNode;
            if (n == null)
            {
                Console.WriteLine("The list is empty.");
            }
            else
            {
                Console.WriteLine("Please enter the element to be searched");
                int elem = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                while (n.next != null)
                {
                    if (n._data == elem)
                    {
                        Console.WriteLine("Element found at position {0}", count);
                        break;
                    }
                   else if (n.next._data == elem)
                    {
                        Console.WriteLine("Element found at position {0}", count+1);
                        break;
                    }
                    else
                    {
                        n = n.next;
                        count++;

                    }
                }
            }
        }
    }
}
