using System;
using System.Collections.Generic;
using System.Text;

namespace Collections1
{
    class SampleSortedSet
    {
        public static void Main(string[] args)
        {
            SortedSet<string> names = new SortedSet<string>();
            names.Add("paru");
            names.Add("geetha");
            names.Add("teju");
            names.Add("swetha");
            names.Add(null);

            foreach (string s in names)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            

            
        }
    }

}
