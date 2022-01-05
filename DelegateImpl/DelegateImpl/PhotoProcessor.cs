using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateImpl
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler (Photo photto);

        public void Process(string path, PhotoFilterHandler photoFilterHandler)
        {
            Photo photo = Photo.Load(path);
            photoFilterHandler(photo);
            photo.Save();
        }
    }
}
