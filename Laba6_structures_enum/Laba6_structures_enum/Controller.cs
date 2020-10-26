using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6_structures_enum
{
    class Controller
    {

        public float averageDisplaceSailboat { get; private set; } = 0;



        public int averageCrewSteamship { get; private set; } = 0;
       
        


        public float AverageDisplaceSailboat(Port port)
        {
            float val=0;
            int count = 0;

            for(int i=0; i<=port.vehicles.Length; i++ )
            {
                if (port.vehicles[i] == null)
                    break;
                if (Convert.ToString(port.vehicles[i].GetType()) == "Laba6_structures_enum.Sailboat")
                {
                    val = val + port.vehicles[i].displacement;
                    count++;
                }
            }
            if (count == 0) return 0;
            val = val / count;
            Console.WriteLine("Среднее водоизмещение парусников: " + val);
            averageDisplaceSailboat = val;
            Console.WriteLine();
            return val;
        }

        public int AverageCrewSteamship(Port port)
        {
            int val = 0;
            int count = 0;
            for (int i = 0; i <= port.vehicles.Length; i++)
            {
                if (port.vehicles[i] == null)
                    break;
                    if (Convert.ToString(port.vehicles[i].GetType()) == "Laba6_structures_enum.Steamship")
               

                {
                    val = val + port.vehicles[i].crew;
                    count++;
                }
            }
            if (count == 0) return 0;
            val = val / count;
            Console.WriteLine("Среднее количество посадочных мест: " + val);
            averageCrewSteamship = val;
            Console.WriteLine();
            return val;
        }

        public void LessThan35(Port port)
        {
            
            foreach (Vehicle i in port.vehicles)
            {
                if (i == null)
                    break;
                if (i.captain.age<35)
                {
                    Console.WriteLine("           " +Convert.ToString(i.GetType())+"    "+ i.captain.name);
                   
                }
            }
            Console.WriteLine();
        }

    }
}
