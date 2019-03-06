using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> mylist = new List<object>();
            mylist.Add(7);
            mylist.Add(28);
            mylist.Add(-1);
            mylist.Add(true);
            mylist.Add("chair");
            int sum = 0;
            foreach (var item in mylist){
                if (item is int){
                    // Console.WriteLine($"{item} is an integer!");
                    sum += Convert.ToInt32(item);
                }
            }
            Console.WriteLine($"sum is {sum}");

        }
    }
}
