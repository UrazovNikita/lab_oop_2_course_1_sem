using System;
using System.Collections.Generic;
using System.Text;

namespace 
    Laba8_generic
{
    class Ship : Vehicle
    {
        public string applicationArea = "civil"; 
        

       
        public override void ring() {
            Console.WriteLine("ring");
        }

     
        public string ToString()
        {
            string str = Convert.ToString(this.GetType());
            Console.WriteLine(this.crew);
            Console.WriteLine(this.applicationArea);
            Console.WriteLine(this.maxSpeed);
            return str;
        }

     

       

    }
}
