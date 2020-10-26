using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6_structures_enum
{
    struct Sailor
    {
        public string name { get; set; }
        public int age { get; set; }

        public Sailor(string inputName, int inputAge)
        {
            name = inputName;
            age = inputAge;
        }


    }
}
