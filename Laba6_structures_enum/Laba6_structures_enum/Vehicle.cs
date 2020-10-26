using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;

namespace Laba6_structures_enum
{
    abstract class Vehicle : IVehicleActions
    {
        
        public int crew { get; set; }
        public string maxSpeed {get; set;}
       public string applicationArea { get; set; }

        public int displacement { get; set; }

       public Captain captain { get; protected set; }

        protected Sailor benjamin;

        public void move() {
            Console.WriteLine(Convert.ToString(this.GetType()) + " is moving");        
        }

        
        public void stop()
        {
            Console.WriteLine(Convert.ToString(this.GetType()) + " has been stoped");

        }
        public abstract void ring();
       


}
}
