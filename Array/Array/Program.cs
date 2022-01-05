using System;

namespace ArrayImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 12, 4, 5, 2, 18 };
            Console.WriteLine("Length :" + numbers.Length);

            var number = Array.IndexOf(numbers, 5);
            Console.WriteLine("Index Of 5 :" + number);

            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Effect of clear :");
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }

            Array.Sort(numbers);
            Console.WriteLine("Effect of Sorting");
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }

            Array.Reverse(numbers);
            Console.WriteLine("Effect of Revering");
            foreach(var n in numbers)
            {
                Console.WriteLine(n);
            }

        }
    }
}
