using System;
using System.Text;

namespace StringBuilderImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Shrutik Deshmukh  ";

            Console.WriteLine("Trim : '{0}'", fullName.Trim());
            Console.WriteLine("ToUppper : '{0}'", fullName.Trim().ToUpper());

            int index = fullName.IndexOf(' ');
            string firstName = fullName.Substring(0, index);
            string lastName = fullName.Substring(index + 1);

            Console.WriteLine("FirstName : "+ firstName);
            Console.WriteLine("LastName : "+ lastName) ;

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName :" + names[0]);
            Console.WriteLine("LastName :" + names[1]);

            string name = fullName.Replace("Deshmukh", "Sunil");
            Console.WriteLine("ChangedName :" + name);

            string str = "25";
            int age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 25.5f;
            Console.WriteLine(price.ToString("C"));


            //StringBuilder


            var builder = new StringBuilder();
            builder.Append('-', 20);
            builder.AppendLine();
            builder.Append("Shrutik Deshmukh");
            builder.AppendLine();
            builder.Append('-', 20);

            builder.Replace('-', '+');
            builder.Remove(0, 10);
            builder.Insert(0, new String('-', 10));
            Console.WriteLine(builder);
            Console.WriteLine("First Char :" + builder[13]);



        }
    }
}
