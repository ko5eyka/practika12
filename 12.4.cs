using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._4
{
    internal class Book
    {
        static void Main(string[] args)
        {
            Book book = new Book("777", "Война и мир", "Толстой");
            book.BookInfo();
        }
        public readonly String ISBN;
        public String Title {  get; set; }
        public String Author { get; set; }
        public Book(String isbn, String title, String author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
        }
        public void BookInfo()
        {
            Console.WriteLine($"Книга: {Title}, автор: {Author}, ISBN: {ISBN}");
        }
    }
}
