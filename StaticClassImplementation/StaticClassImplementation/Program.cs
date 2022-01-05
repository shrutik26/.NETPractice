using System;

namespace StaticClassImplementation
{
     class MyCollege
    {
        public static string CollegeName;
        public static string Address;

        static MyCollege()
        {
            CollegeName = "PRMITR";
            Address = "Badnera";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            MyCollege myCollege = new MyCollege();
            Console.WriteLine(MyCollege.CollegeName);
            Console.WriteLine(MyCollege.Address);
            Console.Read();
        }
    }
}
