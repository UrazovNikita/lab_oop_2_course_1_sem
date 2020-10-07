using System;
using System.Collections.Generic;
using System.Text;

namespace Laba4_OOP_overloading
{
    public class Owner
    {
        int Id = 25676;
        string Name = "UUU";
        string UO = "GGGGG";

        public Owner(int Id, string Name, string UO)
        {
            this.Id = Id;
            this.Name = Name;
            this.UO = UO;
        }
        public void GetInfo()
        {
            Console.WriteLine($"{Id},{Name},{UO}");
        }

    }
}
