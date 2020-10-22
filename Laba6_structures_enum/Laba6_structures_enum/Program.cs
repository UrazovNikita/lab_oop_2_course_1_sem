using System;
using System.Reflection.PortableExecutable;

namespace Laba6_structures_enum
{
    class Program
    {
        static void Main(string[] args)
        {

            Corvette ship = new Corvette("jack");



          Vehicle newship = ship as Vehicle;

            Sailboat sailboat = new Sailboat("deen");
            sailboat.crew = "10";
            sailboat.move();
            Console.WriteLine();
            ship.ring();
            Console.WriteLine();
            sailboat.ring();
            sailboat.stop();

           
            




        }
    }
}
