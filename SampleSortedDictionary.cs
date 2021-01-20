using System;
using System.Collections.Generic;
using System.Text;

namespace Collections1
{
    class SampleSortedDictionary
    {
        public static void Main(string[] args)
        {
            SortedDictionary<string, string> emp = new SortedDictionary<string, string>();
            emp.Add("no", "1001");
            emp.Add("name", "paru");
            emp.Add("location", "bangalore");
            emp.Add("salary", "20000");

            foreach (KeyValuePair<string, string> kp in emp)
            {
                Console.WriteLine(kp.Key + ":" + kp.Value);
            }
            emp.Add("domain", ".net");
            Console.WriteLine("\n");
            foreach (KeyValuePair<string, string> kp in emp)
            {
                Console.WriteLine(kp.Key + ":" + kp.Value);
            }
            


        }
    }
}
