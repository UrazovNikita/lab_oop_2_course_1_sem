using System;
using System.Collections.Generic;
using System.Text;

namespace Laba5_OOP_inheritance_polymorphism
{
    class Boat : Vehicle
    {
        public Boat() {
            Console.Write("Ведите количство членов экипажа лодки:");
            this.crew = Console.ReadLine();
            Console.WriteLine();
        }
        public override void ring() {  }

    }
}
