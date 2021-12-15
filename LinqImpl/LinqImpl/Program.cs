using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqImpl
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<String> nameList = new List<string>();
            //nameList.Add("Rajesh Deshmukh");
            //nameList.Add("Kunal Kapoor");
            //nameList.Add("Pooja Gupta");
            //nameList.Add("Rajesha Khanna");
            //nameList.Add("Shital Ingle");
            //nameList.Add("Naman Sharma");
            //nameList.Add("Akshay Sharma");
            //nameList.Add("Hemant Shinde");

            //List<int> numberList = new List<int>();
            //numberList.Add(100);
            //numberList.Add(102);
            //numberList.Add(103);
            //numberList.Add(103);
            //numberList.Add(105);
            //numberList.Add(106);
            //numberList.Add(107);
            //numberList.Add(108);
            //numberList.Add(105);
            //numberList.Add(104);
            //numberList.Add(106);

            //var QuerySyntax = from name in nameList where name == "Pooja Gupta" select name;

            //IEnumerable<string> result = nameList.Select(x => x);

            //var Query_Syntax = from number in numberList where number > 103  select number;

            //var MethodSyntax = (from number in numberList where number > 103 select number).Sum();

            //foreach (var item in QuerySyntax)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.ReadKey();

            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.ReadKey();


            //foreach (var item in Query_Syntax)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.ReadKey();

            //{
            //    Console.Write("Sum is" + MethodSyntax);
                
            //}
            //Console.ReadKey();



        List<Student> Objstudent = new List<Student>()
        {
           new Student() { RoleId = 1, Name = "Suresh Dasari", Gender = "Male", Subjects = new List<string> { "Mathematics", "Physics" } },
           new Student() { RoleId = 2, Name = "Rohini Alavala", Gender = "Female", Subjects = new List<string> { "Entomology", "Botany" } },
           new Student() { RoleId = 3, Name = "Praveen Kumar", Gender = "Male", Subjects = new List<string> { "Computers", "Operating System", "Java" } },
           new Student() { RoleId = 4, Name = "Sateesh Chandra", Gender = "Male", Subjects = new List<string> { "English", "Social Studies", "Chemistry" } },
           new Student() { RoleId = 5, Name = "Madhav Sai", Gender = "Male", Subjects = new List<string> { "Accounting", "Charted" } }
        };

            var studentName = Objstudent.OrderBy(x => x.Name);

            foreach (var student in studentName)
            {
                Console.WriteLine(student.Name + " " + student.Gender);
            }
            Console.ReadLine();


            var studentname = Objstudent.OrderBy(x => x.Name).ThenBy(x => x.RoleId);

            foreach (var student in studentname)
            {
                Console.WriteLine("Name={0} studentid={1}", student.Name, student.RoleId);
            }
            Console.ReadLine();





        }
    }
}
