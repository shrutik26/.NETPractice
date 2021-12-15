using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionImpl
{
    class Program
    {
        static void Main(string[] args)
        {
            //Non-Generic Collection
            //Arraylist
            ArrayList list = new ArrayList();
            list.Add("Sharad Kumar");
            list.Add("Manager");
            list.Add("Mumbai Maharashtra");
            list.Add(42);
            list.Add("673444");


            foreach (var emp in list)
            {
                Console.WriteLine(emp + "");
            }
            Console.WriteLine();

            //Hashtable
            Hashtable hashtable = new Hashtable();
            hashtable.Add("01", "Rajesh Kapoor");
            hashtable.Add("02", "Ramesh Shah");
            hashtable.Add("03", "Sanjay Sharma");
            hashtable.Add("04", "Joe Denver");
            hashtable.Add("05", "Prachi Sharma");
            hashtable.Add("06", "Christian Stweart");
            hashtable.Add("07", "Ram Shinde");

            foreach(DictionaryEntry emp in hashtable)
            {
                Console.WriteLine(emp.Key + "" + emp.Value);
            }

            Console.WriteLine();

            //Sorted List
            SortedList sortedlist = new SortedList();
            sortedlist.Add(1, "Rajesh Kapoor");
            sortedlist.Add(2, "Ramesh Shah");
            sortedlist.Add(3, "Sanjay Sharma");
            sortedlist.Add(4, "Joe Denver");
            sortedlist.Add(5, "Prachi Sharma");
            sortedlist.Add(6, "Christian Stweart");
            sortedlist.Add(7, "Ram Shinde");

            foreach (DictionaryEntry emp in sortedlist)
            {
                Console.WriteLine(emp.Key + "" + emp.Value);
            }

            Console.WriteLine();

            //Stack
            Stack s = new Stack();
            s.Push("Ramesh");
            s.Push("Kunal");
            s.Push(23);
            s.Push(2345);
            s.Push("Rohan");
            s.Push("Pooja");

            foreach (object o in s)
            {
                Console.WriteLine(o + "");
            }

            Console.WriteLine();

            //Queue
            Queue q = new Queue();
            q.Enqueue("Rohit");
            q.Enqueue(12);
            q.Enqueue("Rome");
            q.Enqueue("Sharad");
            q.Enqueue("Swati");
            q.Enqueue(54332322323);


            foreach(object o in q)
            {
                Console.WriteLine(o + "");
            }

        }
    }
}
