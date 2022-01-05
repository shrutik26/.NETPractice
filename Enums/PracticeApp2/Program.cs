using System;

namespace PracticeApp2
{
    public enum collegeDetails
    {
        Name = 1,
        Age = 2,
        Address = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = collegeDetails.Name;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((collegeDetails)methodId);
        }
    }
}
