using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExprImpl
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Book> book = new List<Book>()
            {
                new Book() {BookName = "Book1", Price = 6},
                new Book() {BookName = "Book2", Price = 9},
                new Book() {BookName = "Book3", Price = 13},
            };

            var names = book.Select(x => x.BookName);
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }


            //Sorting using Lambda Expression
            var sortedBooks = book.OrderByDescending(x => x.Price);
            foreach (var books in sortedBooks)
            {
                Console.WriteLine(string.Format("{0} is of price {1}.", books.BookName, books.Price));
            }


            //Lambda Expression
            Func < int,int> Square = number => number * number;

            Console.WriteLine(Square(5));


            //static int Square(int no)
            //{
            //    return no * no;
            //}
        }
    }
}
