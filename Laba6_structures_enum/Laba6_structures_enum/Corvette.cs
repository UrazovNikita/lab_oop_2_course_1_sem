using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6_structures_enum
{
    class Corvette : Vehicle
    {

       public Captain captain;
        public Corvette(string name)
        {
            this.captain = new Captain(name);
        }
        public override void ring() { Console.Beep(500, 300); }
    }
}
