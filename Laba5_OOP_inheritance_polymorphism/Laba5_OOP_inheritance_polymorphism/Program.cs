using System;

namespace Laba5_OOP_inheritance_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship lodka = new Ship(Console.ReadLine());
            lodka.move();
            lodka.ring();
            Steamship steam = new Steamship(Console.ReadLine());
           steam.move();
            steam.ring();

            
        }
    }
}
