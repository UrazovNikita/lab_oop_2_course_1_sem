using System;
using System.Collections.Generic;
using System.Text;

namespace Laba5_OOP_inheritance_polymorphism
{
    class Ship : Vehicle, IVehicleActions
    {
        public string applicationArea = "civil"; 
        public Captain captain;

        public Ship() { }
        public Ship(string captainName)
        {
            this.captain = new Captain(captainName);
            name = captainName;
            
        }
        public override void ring() {
            Console.WriteLine("ring");
        }

        void IVehicleActions.ring()
        {
            Console.WriteLine("ring interface");
        }
        //public override string ToString()
        //{
        //    string str = Convert.ToString(this.GetType());
        //    Console.WriteLine(this.crew);
        //    Console.WriteLine(this.applicationArea);
        //    Console.WriteLine(this.maxSpeed);
        //    return str;
        //}

     

       

    }
}
