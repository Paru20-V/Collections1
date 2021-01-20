using System;
using System.Collections.Generic;
using System.Text;

namespace Collections1
{
    class SampleQueue
    {
        public static void Main(string[] args)
        {
            //Queue<int> nums = new Queue<int>();
            //nums.Enqueue(40);
            //nums.Enqueue(30);
            //nums.Enqueue(170);
            //nums.Enqueue(300);

            Queue<string> nums = new Queue<string>();
            nums.Enqueue("xx");
            nums.Enqueue("yy");
            nums.Enqueue(null);
            nums.Enqueue("zz");
            nums.Enqueue("aa");


            foreach (string i in nums) { 
         
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine(nums.Peek());
            nums.Dequeue();
            Console.WriteLine();
            foreach (string i in nums)
            {
                Console.WriteLine(i);
            }
           

        }
    }
}
