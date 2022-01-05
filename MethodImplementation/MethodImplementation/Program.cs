using System;

namespace MethodImplementation
{
    public class Customer
    {
        private string Name;

        public void setName(string name)
        {
            Name = name;
        }

        public string getName()
        {
            return Name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.setName("Shrutik Deshmukh");
            Console.WriteLine(customer.getName());
        }
    }
}
