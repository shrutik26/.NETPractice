using System;

namespace InheritanceImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();
            text.Width = 100;
            text.Copy();

            text.fontSize = 12;
            text.Addhyperlink("www.google.com");

        }
    }
}
