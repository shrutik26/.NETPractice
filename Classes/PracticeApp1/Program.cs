using System;

namespace PracticeApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.firstName = "Shrutik";
            //person.lastName = "Deshmukh";
            //person.Introduction();


            //Calculator calculator = new Calculator();  
            //var result1 = calculator.add(2, 3);
            //Console.WriteLine(result1);

            //int result2 = calculator.multiply(5, 3);
            //Console.WriteLine(result2);


            Person p = new Calculator();
            p.Method1();
            p.Method2();
            p.Method3();

            Calculator c = (Calculator)p;
            c.Method1();
            c.Method2();
            c.Method3();



        }
    }
}
