using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    internal class User : Human
    {
        public User(string name, int age) : base(name, age) { }
        public User() {}
        public override void Read(Book book)
        {
            Console.WriteLine($"Я прочитал {book.Name} и там было {book.CountOfPages} страниц");
        }
        public void LikeBook(Book book)
        {
            book.Like(this);
        }

    }
}
