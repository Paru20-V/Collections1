using System;
using System.Collections.Generic;
using System.Text;

namespace Collections1
{
    class SampleSortedList
    {
        public static void Main(string[] args){

            SortedList<int, string> colours = new SortedList<int, string>();
            colours.Add(8,"pink");
            colours.Add(5,"red");
            colours.Add(2,"white");
            colours.Add(1,"blue");

            foreach (KeyValuePair<int,string> k in colours)
            {
                Console.WriteLine(k.Key +":" +k.Value);
            }
            colours.RemoveAt(3);
            Console.WriteLine("after deleting..");
            foreach (KeyValuePair<int, string> k in colours)
            {
                Console.WriteLine(k.Key + ":" + k.Value);
            }


        }
    }
}
