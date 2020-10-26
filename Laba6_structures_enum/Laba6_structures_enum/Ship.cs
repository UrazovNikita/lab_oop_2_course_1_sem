using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Laba6_structures_enum
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
                return crew;
            }

            set
            {
                if (value <= Convert.ToInt32(CrewLimit.vehiclesMaxCrew.Ship))
                {
                    crew = value;
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
