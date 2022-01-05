using System;

namespace AbstractClassImplementation
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("The Rectangle is Drawn");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.Draw();


            Rectangle rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
