using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    internal abstract class Human
    {
        public string Name { get; }
        public int Age { get; }
        public int Height { get; }
        public Human(string name, int age, int height)
        {
            Name = name;
            Age = age;
            Height = height;
        }
        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Human()
        {

        }
        public abstract void Read(Book book);
    }
}
