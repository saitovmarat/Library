using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Librarian : Human
    {
        public Librarian(string name, int age) : base(name, age) { }
        public Librarian() { }
        public override void Read(Book book)
        {
            Console.WriteLine("I'm Librarian! I'm not Reading!");
        }
        public void SomeWordsAboutBook(Book book)
        {
            if (book.Name == "Война и мир")
            {
                Console.WriteLine("This is the best book of ALL time!!!");
            }
            else
            {
                Console.WriteLine("Who is gonna read this book?");
            }
        }
        public List<Book> SortedBooks(List<Book> books)
        {
            foreach (var paperThing in books)
            {

            }
            return books;
        }


    }
}
