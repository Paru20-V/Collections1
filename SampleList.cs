using System;
using System.Collections.Generic;

namespace Collections1
{
    class SampleList
    {
         public static void Main(string[] args)
        {
            List<string> li = new List<string>() {"myagi","deepthi"};
            li.Add("paru");
            li.Add("geetha");
            li.Add("swetha");
            li.Add(null);
            

            foreach (string s in li )//retriving elements
            {
                Console.WriteLine(s);
            }

            li.Insert(2,"bannu");//inserting element at 2nd position

            
            Console.WriteLine("after inserting element at middle");
            foreach (string s in li)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("list capacity :" + li.Capacity);
            li.RemoveRange(1, 2);//deleting elements starts from 1st postion and no.of deleting elements(count) 2
            li.Add("paru");//adding duplicate element
            Console.WriteLine("after deleting element at middle");
            foreach (string s in li)
            {
                Console.WriteLine(s);
            }

        }
    }
}
