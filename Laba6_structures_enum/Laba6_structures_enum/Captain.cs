﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6_structures_enum
{
   sealed class Captain
    {
        public Captain() { }

        public Captain(string inputName, int inputAge)
        {
            name = inputName;

            age = inputAge;
        }
        public string name { get; set; }
        public int age { get; set; }

    }
}
