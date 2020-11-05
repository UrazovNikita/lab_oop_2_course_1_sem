using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Laba7_exceptions
{
    class Boat : Vehicle
    {
        public string applicationArea = "civil";
        public Boat() {
            
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
