using Laba6_structures_enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6_structures_enum
{
    partial class Port
    {
        public string name { get; private set; }
         public Vehicle[] vehicles { get; private set; }
        private int count = 0;
        public int size { get; private set; }
        public Port(string inputName, int inputSize)
        {
            name = inputName;
            size = inputSize;
            vehicles = new Vehicle[size];
        }
    }
}
