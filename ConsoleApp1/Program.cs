using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using ConsoleApp1;
using Microsoft.Win32;

namespace ConsoleApp1
{
    public class GFG
    {
        //private static int grade;
        //Console.Write();

        static public string Main()
        {
            int grade = 75;
            string name = String.Empty;
            int[] array = new int[] {1, 2};
            //ReverseString rs=new ReverseString();
            //rs.GetElement();
            //Count2 c=new Count2();
            //c.Count();
            //LinkedlList l =new LinkedlList();
            //{
            //    l.headNode= new LinkedlList.Node(1);
            //}
            ////l.headNode =new LinkedlList.Node(1);
            //LinkedlList.Node second= new LinkedlList.Node(2);
            //LinkedlList.Node third = new LinkedlList.Node(3);
            //l.headNode.next = second;
            //second.next = third;
            //LinkedlList.Node n = l.headNode;
            //while (n != null)
            //{
            //    Console.Write("{0} ", n._data);
            //    n = n.next;
            //}
            //SinglyLinkedList sl=new SinglyLinkedList();
            //sl.Create();
            //bool isCircular=CircularLoopArray.CircularArrayLoop();
            ListNode head = new ListNode(9);
            ListNode first = new ListNode(2);
            //ListNode second = new ListNode(4);
            head.next = first;
            //first.next = second;
            ListNode head1 = new ListNode(9);
            ListNode first1 = new ListNode(9);
            //ListNode second1= new ListNode(4);
            head1.next = first1;
            //first1.next = second1;
            // ListNode newnode=MergeLinkedList.MergeTwoLists(head, head1);
            //ReverseLinkedList.ReverseList(head);
            // int[] nums = new int[]{2, -1, 1, 2, 2};
            //int[] nums = new int[] {-1, 2};
            //int[] nums = new int[] {-2, 1, -1, -2, -2};
            //int[] nums = new int[] {2,0,-2 };
            //ListNode newnode=ReverseLinkedList.Add(head,head1);

            //bool isCircular = Solution.CircularArrayLoop(nums);

            //Singleton obj =Singleton.GetInstance;
            //Singleton obj2 = Singleton.GetInstance;
            //BaseClass d=new BaseClass();
            //d.Print();
            //BaseClass obj=new DerivedClass();
            //obj.Print();
            // d.Print();

            //ChildConstructors obj=new ChildConstructors("Hello");
            //ChildConstructors obj2 = new ChildConstructors();
            //string s = "Hello";
            //int d=s.GetCount();
            //int f=ExtensionMethod.GetCount("Hello World");

            //PassBy_ValueRef obj =new PassBy_ValueRef();
            //Console.WriteLine("Before Passing {0}",name);
            //name=obj.PassByValue("Hello");
            //Console.WriteLine("After Passing {0}", name);
            Generic<int> obj = new Generic<int>();
            var s=obj.Calculate<string>("Hello", "World");
            var integer= obj.Calculate<int>(10,20);
            Hashtable obj1 = new Hashtable()
            {
                {1,1},
                {2,2 },
                { "Hello","World"}
            };
            var d = obj1[5];

            ArrayList myArryList = new ArrayList()
            {
                1,
                "Two",
                3,
                4.5F
            };

            foreach (var val in myArryList)
                Console.WriteLine(val);

            foreach (DictionaryEntry item in obj1)
                Console.WriteLine("key:{0}, value:{1}", item.Key, item.Value);

            Dictionary<int,int> objdc=new Dictionary<int, int>()
            {
                { 1,2},
                {2,3 }
            };

            //var d1 = objdc[5];

            Dictionary<string, int> objdc2 = new Dictionary<string, int>()
            {
                { "1",2},
                {"2",3 }
            };

            var tup = Tuple.Create("1", 2, 3,4,5,6,7,8);
            Console.WriteLine(tup.Item1,tup.Item2,tup.Item3);
           var tuple= GetTuples(Tuple.Create(1, 2));
            UseParams(1,"2",9.00);

            List<Employee> objList= new List<Employee>()
            {
                new Employee(){Id=1,Name="John"}
            };
            objList.Add(new Employee(){Id=2,Name="Chris"});
            var top = objList.SelectMany(c=>c.Name);
            foreach (var VARIABLE in top)
            {
                Console.WriteLine(VARIABLE);
                
            }

            Book[] bookArray = {
                new Book() { Id = 1, Category = "Fiction", PubYear = 1997 } ,
                new Book() { Id = 2, Category = "Bios & Memoirs",  PubYear = 2015 } ,
                new Book() { Id = 3, Category = "Business",  PubYear = 2015 } ,
                new Book() { Id = 4, Category = "Classics" , PubYear = 1962 } ,
                new Book() { Id = 5, Category = "History" , PubYear = 2000 } ,
                new Book() { Id = 6, Category = "Fiction",  PubYear = 2001 } ,
                new Book() { Id = 7, Category = "Bios & Memoris",PubYear = 1997  }
            };
            Book[] bookAuthorsArray = {
                new Book() { Id = 1, Author = "Smith" } ,
                new Book() { Id = 2, Author = "Johnson"} ,
                new Book() { Id = 3, Author = "Wells"} ,
                new Book() { Id = 4, Author = "Rice" }
            };
            var join = from b in bookArray
                join b2 in bookAuthorsArray on b.Id equals b2.Id
                select b;
                       //    new
                       //{
                       //    Id = b.Id,
                       //    Category = b.Category,
                       //    PubYear = b.PubYear,
                       //    Author = b2.Author
                       //};

            var query = bookArray.Join(bookAuthorsArray, b => b.Id, c => c.Id, (book, c) => new
            {
                c.Id,
                c.Author


            });

            foreach (var VARIABLE in query)
            {
                Console.WriteLine($"{VARIABLE.Id} has {VARIABLE.Author}");
                
            }

            //int value = 3;
            //int[] nums =new int[4] {2,3,2,3};
            //int l = RemoveElement(nums,value);
            //foreach (var item in nums)
            //{
            //    Console.WriteLine($"items are {item}");
            //}
            //Divide(-2147483648,- 1);
            Console.ReadKey();
            return "Hello";

        }

        public static int Divide(int dividend, int divisor)
        {
            int i = 0;
            bool negative = false;
            if (dividend > 0)
            {
                if (divisor == 1)
                    return dividend;
                if (divisor == -1)
                    return -dividend;
                while (dividend > 0 && dividend >= divisor)
                {
                    if (divisor < 0)
                    {
                        negative = true;
                        dividend = dividend + divisor;
                        divisor = -(divisor);
                    }
                    else
                        dividend = dividend - divisor;

                    i++;
                }

                if (negative)
                    return -i;
                return i;
            }
            else
            {

                if (divisor == 1)
                {
                    if (dividend == Int32.MinValue)
                        return dividend - 1;
                    return dividend;
                }

                if (divisor == -1)
                {
                    dividend = -(dividend);
                    if (dividend == Int32.MinValue)
                    {
                        dividend = dividend + 1;
                        return -dividend;
                    }
                       
                    return dividend;
                }

              
                while (dividend < 0)
                {
                    if (divisor < 0)
                    {
                        negative = true;
                        dividend = dividend - divisor;
                     
                    }
                    else
                        dividend = dividend + divisor;

                    if (dividend > 0)
                        break;

                    i++;
                }

                if (negative)
                    return i;
                return -i;
            }
        }

        public static int RemoveElement(int[] nums, int val)
        {
           

            nums = nums.Where(e => e != val).ToArray();

            return nums.Length;

        }

        public static void UseParams(params object[] p1)
        {

        }

        public static Tuple<int,int> GetTuples(Tuple<int,int> i)
        {
            return new Tuple<int, int>(i.Item1,i.Item2);

        }

        public static (string, int, int) Return()
        {
            return ("hello",1,2);

        }
        //public static void GiveCredit(int[] grade9)
        //{
        //    Array[]

        //}



    }

    internal class Book
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public int PubYear { get; set; }
        public string Author { get; internal set; }
    }
}