﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Laba5_OOP_inheritance_polymorphism
{
    class Ship : Vehicle
    {
        public override void ring() { Console.Beep(800, 300); }
    }
}