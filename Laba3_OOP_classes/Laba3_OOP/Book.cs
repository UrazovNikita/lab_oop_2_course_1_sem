using System;
using System.Collections.Generic;
using System.Text;

namespace Laba3_OOP
{
    public partial class Book
    {
        private string name { get; set; }
        private string author { get; set; }
        private static string matertial { get; set; }
        public static int count = 0;
        private readonly int hashid = 5 * count;
        private const int pages = 500;
        static Book()
        {
            matertial = "paper";

        }

        public Book() { name = "unnamed"; author = "undefined"; count++; }
        public Book(string n) { name = n; author = "undefined"; }

        //public Book(string n, string a) { name = n; author = a; }  

        private Book(string n, string a) { name = n; author = a; }




      
    }
}