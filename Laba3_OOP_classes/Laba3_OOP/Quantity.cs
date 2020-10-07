using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection.Metadata;

namespace Laba3_OOP
{
   public class Quantity

    {
       
        public Quantity() { name = "Unknown"; CountOfItems++; }      // 1 конструктор

        public Quantity(string n) { name = n;}         // 2 конструктор

        private string ForbidenName = "ForbidenName";
        private Quantity(string k, string h) { }


        private static int CountOfItems=0;

        public readonly static double hash = CountOfItems * 1.7;

        public string name;
        public string data
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

public const int Constant= 5;

        private List<int> _items = new List<int>();

        private int Count => _items.Count;

        public int Summ()
        {
            int sum = 0;
            foreach (int p in _items)
            {
                sum = sum + p;
            }
            return sum;
        }

        public bool IsLessZero()
        {
            foreach (int p in _items)
            {
                if (p < 0)
                {
                    return true;
                }
               

            }
            return false;
        }

        public void PrintQuantity()
        {
            Console.Write("count:" + Count + "    ");

            foreach (int p in _items)
            {
                Console.Write(p+" "); 
            }
            Console.WriteLine();
        }

        public void AddElement(int item)
        {
            if(!_items.Contains(item))
            {
                _items.Add(item);
            }
        }
        public void DelElement(int item)
        {
            if(!_items.Contains(item))
            {
                Console.WriteLine("Такого элемента нет!");
            }
            if (_items.Contains(item))
            {
                _items.Remove(item);
            }
        }

        public int CountElement()
        {
            return Count;
        }

            


    }
}
