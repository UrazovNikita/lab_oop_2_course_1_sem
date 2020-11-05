using Laba6_structures_enum;
using System;
using System.Reflection.PortableExecutable;

namespace Laba6_structures_enum
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

            Steamship steamship1 = new Steamship("ivan", 30);
            steamship1.crew = 255;
            Corvette corvette1 = new Corvette("deen", 25);
            Sailboat sailboat1 = new Sailboat("jack", 45);
            sailboat1.displacement = 200;
            Sailboat sailboat2 = new Sailboat("victor", 45);
            sailboat2.displacement = 300;
            Sailboat sailboat3 = new Sailboat("maks", 45);
            sailboat3.displacement = 400;

            Steamship steamship2 = new Steamship("sannu", 50);
            steamship2.crew = 400;

            Port port1 = new Port("saintropez", 6);

            port1.Add(steamship1);
            port1.Add(corvette1);
            port1.Add(sailboat1);
            port1.Add(steamship2);

            port1.Delete(corvette1);

            port1.Show();

            Controller controller=new Controller();

            controller.AverageCrewSteamship(port1);
            controller.AverageDisplaceSailboat(port1);
            controller.LessThan35(port1);


            Sailor sailor = new Sailor("Maxim", 22);

            //corvette1.crew = Convert.ToInt32(CrewLimit.vehiclesMaxCrew.Corvette);

            
        }
    }
}
