using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6_structures_enum
{
    interface IVehicleActions
    {
        public void move();
        public void stop();
        public virtual void ring() {  }
       
      
    }
}
