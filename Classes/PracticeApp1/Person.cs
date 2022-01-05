using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp1
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void Introduction()
        {
            Console.WriteLine("My name is " + firstName + " " + lastName);
        }

        public void Method1()
        {
            Console.WriteLine("PersonClass Method1");
        }

        public virtual void Method2()
        {
            Console.WriteLine("PersonClass Method2");
        }

        public virtual void Method3()
        {
            Console.WriteLine("PersonClass Method3");
        }
    }
}
