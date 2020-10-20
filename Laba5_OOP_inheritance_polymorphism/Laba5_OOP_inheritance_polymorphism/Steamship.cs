using System;
using System.Collections.Generic;
using System.Text;

namespace Laba5_OOP_inheritance_polymorphism
{
    class Steamship : Vehicle
    {
        public Steamship(string name) { Captain captain = new Captain(name); }
        public override void ring() { Console.Beep(1000, 300); }
    }
}
