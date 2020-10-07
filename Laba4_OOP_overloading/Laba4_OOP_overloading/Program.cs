﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Program
    {
        class Date
        {
            public string date = DateTime.Now.ToString();
        }

        static void Main(string[] args)
        {
            Program.Date Date = new Program.Date();
            Console.WriteLine("Дата создания: {0}", Date.date);

            string str = "Hello world";
            Console.WriteLine(str);
            Console.WriteLine(str.WordMinus(6));
            Vector one = new Vector(1, 2);
            Vector two = new Vector(3, 4);
            Vector four = new Vector(2, 2);
            Vector three = one + two;
            Console.WriteLine(one > two);
            Console.WriteLine(one < two);
            Console.WriteLine(one == two);
            four.DeletePlus();
            Console.WriteLine("Значения x и y:{0} и {1} ", four.x, four.y);
            Console.WriteLine("Значения x и y:{0} и {1}", two.x, two.y);
            Console.WriteLine("Значение x и y:{0} и {1} ", three.x, three.y);
            Vector Vector = new Vector();
            Vector.user.GetInfo();
            Console.ReadKey();
        }
    }

    public static class StringExtension
    {
        public static string WordMinus(this string str, int c)
        {
            return str.Remove(0, c);

        }
        public static Vector DeletePlus(this Vector Vector)
        {
            if (Vector.x > 0)
            {
                Vector.x = 0;
            }
            if (Vector.y > 0)
            {
                Vector.y = 0;
            }
            return Vector;
        }
    }
    public class Vector
    {

        public Ownew user = new Ownew(15, "Вадим", "БГТУ");

        public int x, y;
        public Vector()
        {
            x = 0;
            y = 0;
        }
        public Vector(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static Vector operator +(Vector Vector, Vector Vector1)
        {

            return new Vector(Vector.x + Vector1.x, Vector.y + Vector1.y);
        }
        public static bool operator >(Vector Vector, Vector Vector1)
        {
            if (Vector.x * Vector.y > Vector1.x * Vector.y) return true;
            else return false;
        }
        public static bool operator <(Vector Vector, Vector Vector1)
        {
            if (Vector.x * Vector.y < Vector1.x * Vector.y) return true;
            else return false;
        }
        public static Vector operator ==(Vector Vector, Vector Vector1)
        {
            Vector1.x = Vector.x;
            Vector1.y = Vector.y;
            return Vector1;
        }
        public static Vector operator !=(Vector Vector, Vector Vector1)
        {
            Vector1.x = Vector.x;
            Vector1.y = Vector.y;
            return Vector1;

        }
        public static bool operator true(Vector Vector)
        {
            if (Vector.x == 0 && Vector.y == 0) return true;
            else return false;
        }
        public static bool operator false(Vector Vector)
        {
            if (Vector.x != 0 && Vector.y != 0) return true;
            else return false;
        }
        public class Ownew
        {
            int Id = 25676;
            string Name = "UUU";
            string UO = "GGGGG";

            public Ownew(int Id, string Name, string UO)
            {
                this.Id = Id;
                this.Name = Name;
                this.UO = UO;
            }
            public void GetInfo()
            {
                Console.WriteLine($"{Id},{Name},{UO}");
            }

        }

    }
}