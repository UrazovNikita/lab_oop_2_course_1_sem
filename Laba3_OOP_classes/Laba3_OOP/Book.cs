using System;
using System.Collections.Generic;
using System.Text;

namespace Laba3_OOP
{
    public class Book
    {
        private string name;
        private string author;
        private static string matertial;
        private static int count = 0;
        private readonly int hashid=5*count;
        private const int pages = 500;
        static Book()
        {
            matertial = "paper";
            count++;

        }

        public Book() { name = "unnamed"; author = "undefined"; }
        public Book(string n) { name = n; author = "undefined"; }
        //public Book(string n, string a) { name = n; author = a; }  
        
        private Book(string n, string a) {name=n; author = a; }

        


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
