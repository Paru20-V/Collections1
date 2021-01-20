using System;
using System.Collections.Generic;
using System.Text;

namespace Collections1
{
    class SampleStack
    {
        public static void Main(string[] argd)
        {
            //Stack<int> nos = new Stack<int>();
            //nos.Push(100);
            //nos.Push(20);
            //nos.Push(50);
            //nos.Push(10);

            Stack<string> nos = new Stack<string>();
            nos.Push("xx");
           nos.Push(null);
            nos.Push("yy");
            nos.Push("zz");



            foreach (string i in nos)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n"+ nos.Peek());
            nos.Pop();
            Console.WriteLine("\n" + nos.Peek());
            
        }
    }
}
