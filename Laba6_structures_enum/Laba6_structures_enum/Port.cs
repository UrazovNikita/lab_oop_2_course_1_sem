using Laba5_OOP_inheritance_polymorphism;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6_structures_enum
{
     class Port
    {
        public string name{get; private set;}
        private Vehicle[] vehicles;
        private int count = 0;
        private int size;

        public Port(string inputName)
        {
            name = inputName;
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

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
                return;
            vehicles[count++] = newVehicle;

        }

        public void Del(Vehicle vehicle)
        {
            int num = 0;
            if (isEmpty())
                return;
            for (int i = 0; i < count; i++)
            {
                if (an[i].Equals(el))
                    num = i;
            }
            for (int i = num; i < count; i++)
            {
                an[i] = an[i + 1];
            }
            count--;
        }

    }
}
