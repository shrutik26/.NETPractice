using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateImpl
{
    public class PhotoFilter
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Brightness is Applied");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Contrast is Applied");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Photo is resized");
        }
    }
}
