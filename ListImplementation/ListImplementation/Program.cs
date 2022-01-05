using System;
using System.Collections.Generic;

namespace ListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };

            numbers.Add(6);
            numbers.AddRange(new int[] { 7, 8, 9 });

            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("IndexOf 6 :" + numbers.IndexOf(6));
            Console.WriteLine("LastIndex of 6 :" + numbers.LastIndexOf(6));
            Console.WriteLine("Count of list:" + numbers.Count);
            numbers.Remove(3);

            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }
   
        }
    }
}
