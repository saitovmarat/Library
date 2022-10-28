using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class Book
    {
        public string Name { get; private set; }
        public string Author { get; private set; }
        public int CountOfPages { get; private set; }
        public int Rating { get; set; } = 0;
        private List<User> userWhichLiked = new List<User>();
        public Book(string name, string author, int countofpages)
        {
            Name = name;
            Author = author;
            CountOfPages = countofpages;
        }
        public Book(string name, string author, int countofpages, int rating)
        {
            Name = name;
            Author = author;
            CountOfPages = countofpages;
            Rating = rating;
        }
        public void something()
        {

        }
        public void something1()
        {

        }
        private bool UserWhichAlreadyLiked(User user)
        {
            bool isLiked = false;
            foreach (var curUser in userWhichLiked)
            {
                if (curUser == user)
                {
                    isLiked = true;
                }
            }
            return isLiked;
        }
        public override string ToString()
        {
            return $"{Name} {Author} {CountOfPages} {Rating}";
        }
        public void Like(User user)
        {
            if (!UserWhichAlreadyLiked(user))
            {
                Rating++;
                userWhichLiked.Add(user);
            }
            else
            {
                Console.WriteLine("Вы уже лайкнули эту книгу!");
            }
        }



    }
}
