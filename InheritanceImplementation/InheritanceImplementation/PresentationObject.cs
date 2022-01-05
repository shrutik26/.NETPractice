using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceImplementation
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine( "Objects are copied to clipboard" );
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated");
        }
    }
}
