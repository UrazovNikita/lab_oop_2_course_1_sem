using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6_structures_enum
{
    class Sailboat : Vehicle
    {
      public Captain captain;
        public Sailboat(string name)
        {
            this.captain = new Captain(name);
        }
        public override void ring() {  }
    }
}
