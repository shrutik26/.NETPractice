using System;

namespace SealedClassImpl
{
    sealed class SealedClass
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }

    public class Math : SealedClass
    {
        public int Width;
    }
    class Program
    {
        static void Main(string[] args)
        {
            SealedClass sealedClass = new SealedClass();
            int value = sealedClass.Add(10, 20);
            Console.WriteLine("Total = " + value.ToString());
        }
    }
}
