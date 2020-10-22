using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Laba6_structures_enum
{
    abstract class Vehicle : IVehicleActions
    {
        

        public string crew { get; set; }
        protected string maxSpeed {get; set;}
        protected string applicationArea { get; set; }

        public void move() {
            Console.WriteLine(Convert.ToString(this.GetType()) + " is moving");        
        }

        
        public void stop()
        {
            Console.WriteLine(Convert.ToString(this.GetType()) + " has been stoped");

    }
        public virtual void ring()
        {
            Console.WriteLine("RING!!!");
        }


    }
}
