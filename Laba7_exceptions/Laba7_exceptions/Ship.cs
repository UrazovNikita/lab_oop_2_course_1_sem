using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Laba7_exceptions
{
    class Ship : Vehicle, IVehicleActions
    {
        public string applicationArea = "civil";
        

        public Ship() { }
        public Ship(string inputName, int inputAge)
        {
            captain = new Captain(inputName, inputAge);

        }

        public int Crew
        {
            get
            {
                return this.crew;
            }

            
         set
            {
                if (value > Convert.ToInt32(CrewLimit.vehiclesMaxCrew.Ship))
                {
                    throw new Exception("Превышен лимит мест");
                }
                else 
                {
                    this.crew = value;
                }
            }
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
