using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeApp1
{
     public class Calculator : Person
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int multiply(int a, int b)
        {
            return a * b;
        }

       new public void Method1 ()
        {
            Console.WriteLine("Calculatorclass Method1");
        }

        public override void Method2()
        {
            Console.WriteLine("Calculatorclass Method2");
        }

        public new void Method3()
        {
            Console.WriteLine("Calculatorclass Method3");
        }
    }
}
