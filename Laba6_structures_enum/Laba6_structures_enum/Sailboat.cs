using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6_structures_enum
{
    class Sailboat : Vehicle
    {

        public string applicationArea = "civil";
        

        public Sailboat() { }
        public Sailboat(string inputName, int inputAge)
        {
            captain = new Captain(inputName, inputAge);

        }

        public override string ToString()
        {
            string str = Convert.ToString(this.GetType());
            Console.WriteLine(this.crew);
            Console.WriteLine(this.applicationArea);
            Console.WriteLine(this.maxSpeed);
            return str;
        }
        public override void ring() {  }
    }
}
