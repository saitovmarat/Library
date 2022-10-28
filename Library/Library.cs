using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Library
    {
        public List<Book> books = new List<Book>();
        public Library(List<Book> books)
        {
            this.books = books;
        }
        public Library()     
        {
        }
        public void ShowCatalog()
        {
            foreach(var book in books)
            {
                Console.WriteLine(book.ToString());
            }
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void AddBook(List<Book> books)
        {
            books.AddRange(books);
        }
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }
        public void fff()
        {

        }

    }
}
