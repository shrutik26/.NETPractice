using System;

namespace MethodOverriding
{
    class baseClass
    {
        public void Greetings()    
        {
            Console.WriteLine("baseClass Saying Hello!");
        }
    }
    class derivedClass : baseClass
    {
        public  void Greetings()
        {
            
            Console.WriteLine("subClass Saying Hello!");
            //base.Greetings();
        }
        public void Greetings1()
        {
            Console.WriteLine("i am in Greetings1");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            derivedClass obj1 = new derivedClass();
            //baseClass obj1 = new baseClass();
            obj1.Greetings();
            obj1.Greetings1();
            Console.ReadLine();
        }
    }
}
