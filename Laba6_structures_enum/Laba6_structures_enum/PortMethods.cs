
using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6_structures_enum
{
    partial class Port

    {
        private bool isFull()
        {
            return (count == size);
        }

        private bool isEmpty()
        {
            return (count == 0);
        }

        public void Add(Vehicle newVehicle)
        {
            if (isFull())
            {
                return;
            }
            vehicles[count++] = newVehicle;
        }

        public void Delete(Vehicle deleteVehicle)
        {
            if (isEmpty())
                return;
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == deleteVehicle)
                {
                    vehicles[i] = null;
                    int j = i;
                    while (j < size)
                    {
                        if (j + 1 == size)
                        {
                            break;
                        }
                        vehicles[j] = vehicles[j + 1];
                        vehicles[j + 1] = null;
                        j++;
                    }

                    break;
                }


            }
        }

        public void Show()
        {
            Console.Write(name);
            Console.WriteLine();
            int i = 0;
            while (vehicles[i] != null)
            {
                Console.WriteLine("           " + vehicles[i].name);
                i++;
            }
        }

    }
}

}
