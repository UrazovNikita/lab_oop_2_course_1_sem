using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6_structures_enum
{
    class Ship : Vehicle
    {

       public Captain captain;
        public Ship(string name)
        {
            this.captain = new Captain(name);
        }
        public override void ring() { Console.Beep(800, 300); }
    }
}
