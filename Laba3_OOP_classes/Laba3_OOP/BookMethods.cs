using System;
using System.Collections.Generic;
using System.Text;

namespace Laba3_OOP
{
    public partial class Book
    {
        void SetName()
        {
            Console.WriteLine("Введите имя книги");
            name = Console.ReadLine();
        }
        public void SetAuthor(ref string n)
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


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Book m = obj as Book; // возвращает null если объект нельзя привести к типу Book
            if (m as Book == null)
                return false;

            return m.author == this.author && m.name == this.name;
        }

        public override int GetHashCode()
        {
            int hash;
            hash = Book.count * 7;
            return hash;
        }

    }
}

