using System;
using System.Collections;
using System.Collections.Generic;

namespace GenCollectionImpl
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arraylist Impl
            List<int> list = new List<int>();
            list.Add(100);
            list.Add(200);
            list.Add(300);
            list.Add(400);
            list.Add(500);

            foreach (var num in list)
            {
                Console.WriteLine(num + "");
            }
            Console.WriteLine();


            //Dictionary Impl
            Dictionary<int, string> dct = new Dictionary<int, string>();
            dct.Add(1, "Rajesh Kapoor");
            dct.Add(2, "Ramesh Shah");
            dct.Add(3, "Sanjay Sharma");
            dct.Add(4, "Joe Denver");
            dct.Add(5, "Prachi Sharma");
            dct.Add(6, "Christian Stweart");
            dct.Add(7, "Ram Shinde");

            foreach (KeyValuePair<int,string> emp in dct)
            {
                Console.WriteLine(emp.Key + "" + emp.Value);
            }
            Console.WriteLine();


            //SortedList Impl
            SortedList<string, string> sl = new SortedList<string, string>();
            sl.Add("Sameer Shinde", "Pune");
            sl.Add("Rohan Deshpande", "Thane");
            sl.Add("Rajesh Kapoor", "Delhi");
            sl.Add("Kushal Deshmukh", "Pune");
            sl.Add("Rahul Gupta", "Banglore");

            foreach (KeyValuePair<string, string> kvp in sl)
            {
                Console.WriteLine(kvp.Key + "" + kvp.Value);
            }
            Console.WriteLine();

            //Stack Impl
            Stack<string> stk = new Stack<string>();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sqlserver");

            foreach (string subject in stk)
            {
                Console.WriteLine(subject + "");
            }
            Console.WriteLine();

            //Queue Impl
            Queue<string> q = new Queue<string>();
            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sqlserver");

            foreach (string s in q)
            {
                Console.WriteLine(s + "");
            }
        }
    }
}
