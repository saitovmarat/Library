using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Library
{

    internal class Program
    {
        static List<Book> GetBooksFromFile()
        {
            List<Book> books = new List<Book>();
            using (StreamReader stream = new StreamReader("books.txt"))
            {
                string str;
                while((str = stream.ReadLine()) != null)
                {
                    string[] words = str.Split("  ");
                    string name = words[0];
                    string description = words[1];
                    int count;
                    if (!int.TryParse(words[2], out count))
                    {
                        continue;
                    }
                    int rating;
                    if (!int.TryParse(words[3], out rating))
                    {
                        continue;
                    }
                    books.Add(new Book(name, description, count, rating));
                }
            }
            return books;
        }
        static void Main(string[] args)
        {
            User user = new User("Витя", 16);
            User user1 = new User("Катя", 19);
            List<Book> books = GetBooksFromFile();
            Library library = new Library(books);
            user.Read(books.First());
            user.LikeBook(books.First());
            bool enabled = true;
            while (enabled)
            {
                Console.Clear();
                Console.WriteLine("Напишите 1 чтобы добавить кингу, напишите 2 чтобы посмотреть каталог книг, 3 чтобы выйти.");
                int input;
                if (!int.TryParse(Console.ReadLine(), out input))
                {
                    continue;
                }
                switch (input)
                {
                    case 1:
                        library.AddBook(AskUserWhichBookHeWantToCreate());
                        break;
                    case 2:
                        library.ShowCatalog();
                        break;
                    case 3:
                        enabled = false;
                        break;
                    default:
                        Console.WriteLine("Некорректное значение!");
                        break;
                }
                Console.ReadKey();
            }


        }
        private static Book AskUserWhichBookHeWantToCreate()
        {
            Console.WriteLine("Какое название у книги?");
            string name = Console.ReadLine();
            Console.WriteLine("Какой автор этой книги?");
            string author_name = Console.ReadLine();
            Console.WriteLine("Сколько страниц у книги?");
            int cnt_pages;
            while (!int.TryParse(Console.ReadLine(), out cnt_pages))
            {
                Console.WriteLine("Некорректное значение!");
            }
            Book book = new Book(name, author_name, cnt_pages);
            LoadToFile(book);
            return book;
        }
        private static void LoadToFile(Book book)
        {
            using (StreamWriter stream = new StreamWriter("books.txt"))
            {
                stream.WriteLine($"{book.Name}  {book.Author}  {book.CountOfPages}  {book.Rating}");
            }
        }
    }
}
