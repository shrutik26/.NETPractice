using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceImplementation
{
    public class Text : PresentationObject
    {
        public int fontSize { get; set; }
        public string fontName { get; set; }

        public void Addhyperlink(string url)
        {
            Console.WriteLine("We added a link to " +url);
        }
    }
}
