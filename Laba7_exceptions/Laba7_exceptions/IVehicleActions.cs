using System;
using System.Collections.Generic;
using System.Text;

namespace Laba7_exceptions
{
    interface IVehicleActions
    {
        public void move();
        public void stop();
        public virtual void ring() {  }
       
      
    }
}
