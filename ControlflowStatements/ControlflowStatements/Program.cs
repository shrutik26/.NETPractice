using System;

namespace ControlflowStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 19;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("Its Morning !!");
            }
            else if (hour > 12 && hour < 18)
            {
                Console.WriteLine("Its AfterNoon !!");
            }
            else
            {
                Console.WriteLine("Its Evening !!");
            }

        }
    }
}
