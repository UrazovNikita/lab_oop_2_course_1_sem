using System;
using System.Collections.Generic;
using System.Text;


namespace Laba5_OOP_inheritance_polymorphism
{
    class Steamship : Vehicle
    {
        Captain captain;
        public Steamship(string name)
        {
            this.captain = new Captain(name);
        }
        public override void ring() { Console.Beep(1000, 300); }

        public override string ToString()
        {
            string str = "Метод 'ToStrig' переопределен";
            Console.WriteLine(str);
            return str;
        }
        public override int GetHashCode()
        {
            return Convert.ToInt32(Convert.ToInt32(crew)*(Math.PI));
        }

        public override bool Equals(object obj)
        {
            //bool val = ==Steamship ? true : false;
            bool val = true;
            Console.WriteLine(" Метод 'Equals' переопределен");
            return val;
        }
    }
}
