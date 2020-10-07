using System;
using System.Collections.Generic;
using System.Text;

namespace Laba3_OOP
{
    public class Book
    {
        private string name;
        private string author;

      public void SetName()
        {
            Console.WriteLine("Введите имя книги");
            name = Console.ReadLine();
        }
        public void SetAuthor()
        {
            Console.WriteLine("Введите имя автора");
            author = Console.ReadLine();
        }
        public void PrintBook()
        {
            Console.WriteLine();
            Console.WriteLine(name);
            Console.WriteLine(author);
        }
    }
}
