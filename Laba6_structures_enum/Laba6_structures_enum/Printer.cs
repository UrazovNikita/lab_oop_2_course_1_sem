using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6_structures_enum
{
    class Printer
    {
        static public void iAmPrinting(IVehicleActions objects)
        {
            Console.WriteLine(objects.ToString());
        }
    }
}

