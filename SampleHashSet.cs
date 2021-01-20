using System;
using System.Collections.Generic;
using System.Text;

namespace Collections1
{
    class SampleHashSet
    {
        public static void Main(string[] args)
        {

            HashSet<string> Langs = new HashSet<string>();
            Langs.Add("Java");
            Langs.Add(".net");
            Langs.Add("c");
            Langs.Add("c++");
            Langs.Add(null);

            Console.WriteLine("the names of languages are..");
            foreach (string l in Langs)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine();
            Langs.Add("Java");//adding duplicate element
            foreach (string l in Langs)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine();
            Langs.Remove("c");
           
            foreach (string l in Langs)
            {
                Console.WriteLine(l);
            }
            



        }
    }
}
