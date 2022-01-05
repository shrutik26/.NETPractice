using System;

namespace DelegateImpl
{
    class Program
    {
        public delegate void delmethod();

        static void Main(string[] args)
        {
            PhotoProcessor processor = new PhotoProcessor();
            PhotoFilter photoFilter = new PhotoFilter();
            PhotoProcessor.PhotoFilterHandler photoFilterHandler = photoFilter.ApplyBrightness;
            photoFilterHandler += photoFilter.ApplyContrast;
            photoFilterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg", photoFilterHandler);
           
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Red eye filter removed");
        }
    }
}
