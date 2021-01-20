using System;
using System.Collections.Generic;
using System.Text;

namespace Collections1
{
    class SampleDictionary
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> emp = new Dictionary<string, string>();
            emp.Add("no","1001");
            emp.Add("name","paru");
            emp.Add("location","bangalore");
            emp.Add("salary","20000");
            emp.Add("ss",null);
            emp.Add(null,"xx");//throwing argument null exception..key cannot be null

            foreach (KeyValuePair<string,string> kp in emp)
            {
                Console.WriteLine(kp.Key +":" + kp.Value);
            }
            emp.Add("domain",".net");
            Console.WriteLine("\n");
            foreach (KeyValuePair<string, string> kp in emp)
            {
                Console.WriteLine(kp.Key + ":" + kp.Value);
            }
            emp.Remove("salary");
            Console.WriteLine("\n");
            foreach (KeyValuePair<string, string> kp in emp)
            {
                Console.WriteLine(kp.Key + ":" + kp.Value);
            }
            Console.WriteLine("\n");
            foreach (KeyValuePair<string, string> kp in emp)
            {
                Console.WriteLine(kp.Key);//getting only keys
            }

            Console.WriteLine(emp.ContainsValue("1001"));

        }
    }
}
