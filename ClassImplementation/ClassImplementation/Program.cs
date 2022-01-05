using System;

namespace ClassImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1,"Shrutik");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
