using System;
using System.Collections.Generic;
using System.Text;

namespace Collections1
{
    class SampleLinkedList
    {
        public static void Main(string[] args)
        {
            LinkedList<string> veg = new LinkedList<string>();
            veg.AddFirst("carrot");
            veg.AddFirst("tomoto");
            veg.AddLast("brinzal");
            veg.AddLast("onion");
           // veg.AddLast(null); throwing argument null exception

            foreach (string s in veg)
            {
                Console.WriteLine(s);
            }

            LinkedListNode<string> node = veg.Find("carrot");
            veg.AddBefore(node,"pumpkin");
            veg.AddAfter(node,"cyabez");

            Console.WriteLine("after adding..");
            foreach (string s in veg)
            {
                Console.WriteLine(s);
            }
            veg.Remove("brinzal");
            Console.WriteLine("after deleting...");
            foreach (string s in veg)
            {
                Console.WriteLine(s);
            }

        }
    }
}
