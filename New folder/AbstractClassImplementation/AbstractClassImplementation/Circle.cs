using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassImplementation
{
    public class Circle : Shape
    {
        public float Radius { get; set; }

        public override void Draw()
        {
            Console.WriteLine("The circle is drawn");
        }
    }
}
