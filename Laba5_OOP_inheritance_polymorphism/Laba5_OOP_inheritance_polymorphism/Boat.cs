using System;
using System.Collections.Generic;
using System.Text;

namespace Laba5_OOP_inheritance_polymorphism
{
    class Boat : Vehicle
    {
        
        public Boat(string name) { Captain captain = new Captain(name); }

        public override void ring() {  }

    }
}
