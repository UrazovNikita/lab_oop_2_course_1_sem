using System;
using System.Collections.Generic;
using System.Text;


namespace Laba7_exceptions
{
    class Steamship : Vehicle
    {

        public string applicationArea = "civil";
       
        public int Crew
        {
            get
            {
                return crew;
            }

            set
            {
                if (value <= Convert.ToInt32(CrewLimit.vehiclesMaxCrew.Steamship))
                {
                    crew = value;
                }
            }
        }

        public Steamship() { }
        public Steamship(string inputName, int inputAge)
        {
            captain = new Captain(inputName, inputAge);

        }
        public override void ring() { Console.Beep(1000, 300); }

        public override string ToString()
        {
            string str = Convert.ToString(this.GetType());
            Console.WriteLine(this.crew);
            Console.WriteLine(this.applicationArea);
            Console.WriteLine(this.maxSpeed);
            return str;
        }
        public override int GetHashCode()
        {
            return Convert.ToInt32(Convert.ToInt32(crew)*(Math.PI));
        }

        public override bool Equals(object obj)
        {
            //bool val = ==Steamship ? true : false;
            bool val = true;
            Console.WriteLine(" Метод 'Equals' переопределен");
            return val;
        }
    }
}
