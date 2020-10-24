using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Laba6_structures_enum
{
    class Boat : Vehicle
    {
        public string applicationArea = "civil";
        public Boat() {
            Console.Write("Ведите количство членов экипажа лодки:");
            this.crew = Console.ReadLine();
            Console.WriteLine();
        }

        public override string ToString()
        {
            string str = Convert.ToString(this.GetType());
            Console.WriteLine(this.crew);
            Console.WriteLine(this.applicationArea);
            Console.WriteLine(this.maxSpeed);
            return str;
        }
        public override void ring() {  }

    }
}
