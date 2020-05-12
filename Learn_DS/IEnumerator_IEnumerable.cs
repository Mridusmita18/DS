using System;
using System.Collections.Generic;
using System.Text;

namespace Learn_DS
{
    static class IEnumerator_IEnumerable
    {

        public static IEnumerable<int> GetItems()
        {
            List<int> list = new List<int>()
        {
            10,20,60,90,100
        };

            IEnumerable<int> ienumerablelist = (IEnumerable<int>)list;
            foreach (int i in ienumerablelist)
                Console.WriteLine(i);
            IEnumerator<int> ienumeratorlist = list.GetEnumerator();
            while (ienumeratorlist.MoveNext())
                Console.WriteLine(ienumeratorlist.Current);

            foreach (int i in list)
            {
                if (i > 20)
                    yield return i;
            }
        }
    }
}
