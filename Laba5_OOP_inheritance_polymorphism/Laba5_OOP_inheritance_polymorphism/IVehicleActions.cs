using System;
using System.Collections.Generic;
using System.Text;

namespace Laba5_OOP_inheritance_polymorphism
{
    interface IVehicleActions
    {
        public void move();
        public void stop()

        { 
            Console.WriteLine("Stoped!");
        }
        public virtual void ring() {  }
       
      
    }
}
