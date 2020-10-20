using System;
using System.Collections.Generic;
using System.Text;

namespace Laba5_OOP_inheritance_polymorphism
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
