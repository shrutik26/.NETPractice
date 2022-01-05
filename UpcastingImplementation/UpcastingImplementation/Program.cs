using System;

namespace UpcastingImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();
            Shape shape = text;          //Upcasting

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);

            //Shape shape = new Text();
            //Text text = (Text)shape;  //Downcasting

            //text.fontSize = 100;

            //Console.WriteLine(text.fontSize);
            
        }
    }
}
