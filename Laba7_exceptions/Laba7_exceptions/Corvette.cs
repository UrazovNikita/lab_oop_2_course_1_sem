using System;
using System.Collections.Generic;
using System.Text;

namespace Laba7_exceptions
{
    class Corvette : Vehicle
    {
       public string applicationArea = "military";

       

        public Corvette() { }
        public Corvette(string inputName, int inputAge)
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
                if (value <= Convert.ToInt32(CrewLimit.vehiclesMaxCrew.Corvette))
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
        public override void ring() { Console.Beep(500, 300); }
    }
}
