using Laba6_structures_enum;
using System;
using System.Reflection.PortableExecutable;

namespace Laba5_OOP_inheritance_polymorphism
{
    class Program
    {

        static void Main(string[] args)
        {

            //Corvette ship = new Corvette("jack");



            //IVehicleActions newship = new Ship("deen");
            //Ship newship1 = new Ship("deen");

            //Sailboat sailboat = new Sailboat("deen");
            //sailboat.crew = "10";
            //sailboat.move();
            //Console.WriteLine();
            //ship.ring();
            //Console.WriteLine();
            //sailboat.ring();
            //sailboat.stop();

            //newship.ring();
            //((IVehicleActions)newship1).ring();



            //Captain captain2 = new Captain("Ivan");


            //IVehicleActions[] objects = new IVehicleActions[3];
            //objects[0] = new Ship();
            //objects[1] = new Corvette();
            //objects[2] = new Sailboat();
            //foreach (IVehicleActions obj in objects)
            //{
            //    Printer.IAmPrinting(obj);
            //}

            Ship ship1 = new Ship("ivan");
            Ship ship2 = new Ship("deen");
            Ship ship3 = new Ship("jack");
            Ship ship4 = new Ship("sannu");
            Port port1 = new Port("santrope", 6);

            port1.Add(ship1);
            port1.Add(ship2);
            port1.Add(ship3);
            port1.Add(ship4);

            port1.Delete(ship2);

            port1.Show();
        }
    }
}
