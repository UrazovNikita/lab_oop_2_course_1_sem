﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba8_generic
{

    class Program
    {
       

        static void Main(string[] args)
        {
           

            string str = "Hello world";
            Console.WriteLine(str);
            Console.WriteLine(str.WordMinus(6));
            Vector one = new Vector(1, 2);
            Vector two = new Vector(3, 4);
            Vector four = new Vector(2, 2);

            Console.WriteLine(one.date.date);

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

    public static class StatisticOperation
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
    
}
