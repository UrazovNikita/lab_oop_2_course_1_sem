using System;
using System.Collections.Generic;
using System.Text;

namespace Laba8_generic
{
    public class Owner
    {
        int Id = 25676;
        string Name = "UUU";
        string UO = "BGTU";

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
