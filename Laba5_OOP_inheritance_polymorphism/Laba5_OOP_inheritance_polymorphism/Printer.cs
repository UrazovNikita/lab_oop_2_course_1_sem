﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Laba5_OOP_inheritance_polymorphism
{
    class Printer
    {
        static public void iAmPrinting(IVehicleActions objects)
        {
            Console.WriteLine(objects.ToString());
        }
    }
}
