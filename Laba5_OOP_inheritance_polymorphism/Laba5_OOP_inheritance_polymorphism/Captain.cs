﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Laba5_OOP_inheritance_polymorphism
{
   sealed class Captain
    {

        public Captain(string name)
        {
            this.name = name;
        }
        public string name { get; set; }
        public string age { get; set; }

    }
}
