using System;
using System.Collections.Generic;

namespace GenericClassImpl
{

    class Program
    {
        //Generic method  
        static void Swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            //Generic Method Implementation
            int a = 40, b = 60;
            Console.WriteLine("Before swap: {0}, {1}", a, b);

            Swap<int>(ref a, ref b);

            Console.WriteLine("After swap: {0}, {1}", a, b);


            //Generic Class Implementation
            TestClsss<int> intObj = new TestClsss<int>();

            intObj.Add(1);
            intObj.Add(2);
            intObj.Add(3);     
            intObj.Add(4);
            intObj.Add(5);

           
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(intObj[i]);   
            }
            Console.ReadKey();


            //Dictionary Implementation
            Dictionary<string, Employee> dObj = new Dictionary<string, Employee>();
 
            Employee tom = new Employee("tom", 2000);
            dObj.Add("tom", tom);   // key,value  
            Employee john = new Employee("john", 4000);
            dObj.Add("john", john);

            foreach (Object str in dObj.Values)
            {
                Console.WriteLine(str);
            }
            Console.ReadKey();

        }
    }
}
