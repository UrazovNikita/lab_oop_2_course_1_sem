using System;
using System.Collections.Generic;
using System.Text;

namespace Laba5_OOP_inheritance_polymorphism
{
    class Corvette : Vehicle
    {
       public string applicationArea = "military";

        public Captain captain;

        public Corvette() { }
        public Corvette(string name)
        {
            this.captain = new Captain(name);
        }
        public override string ToString()
        {
            string str = Convert.ToString(this.GetType());
            Console.WriteLine(this.crew);
            Console.WriteLine(this.applicationArea);
            Console.WriteLine(this.maxSpeed);
            return str;
        }
        public override void ring() { Console.Beep(500, 300); }
    }
}
