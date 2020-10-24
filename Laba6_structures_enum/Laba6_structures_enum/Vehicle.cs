﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;

namespace Laba5_OOP_inheritance_polymorphism
{
    abstract class Vehicle : IVehicleActions
    {
        public string name { get; set; }
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
        public abstract void ring();
       


}
}
