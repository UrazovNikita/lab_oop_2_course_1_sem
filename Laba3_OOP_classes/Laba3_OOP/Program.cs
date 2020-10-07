using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Serialization;

namespace Laba3_OOP
{

    class Program
    {

        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("1-множество");
            Console.WriteLine("2-классы");

            choice = Int32.Parse(Console.ReadLine());
            
            switch (choice)
            { 


                case 1:
                    var quantity1WithoutParam = new Quantity();
                    var quantity2WithoutParam = new Quantity();
                    Quantity quantity2 = new Quantity("WithName");

                    Quantity[] quantities = new Quantity[3];

                    for (int i = 0; i < quantities.Length; i++)
                    {
                        Console.WriteLine("Введите количество элементов в множестве №" + Convert.ToString(i + 1));
                        int number;
                        number = Convert.ToInt32(Console.ReadLine());

                        quantities[i] = new Quantity();

                        Console.WriteLine("Введите значения: ");
                        for (int j = 0; j < number; j++)
                        {
                            int value = Convert.ToInt32(Console.ReadLine());
                            quantities[i].AddElement(value);
                        }
                    }

                    Console.WriteLine();

                    for (int i = 0; i < quantities.Length; i++)
                    {
                        quantities[i].PrintQuantity();
                    }
                    Console.WriteLine();
                    Console.WriteLine("----------a----------");
                    Console.WriteLine();

                    int max = 0, min = 0;
                    int imin = 0, imax = 0;

                    min = quantities[0].Summ();

                    for (int i = 0; i < quantities.Length; i++)
                    {
                        int val = quantities[i].Summ();
                        if (val < min)
                        {
                            imin = i;
                        }
                    }

                    Console.Write(imin + " ");
                    quantities[imin].PrintQuantity();

                    Console.WriteLine();

                    max = quantities[0].Summ();

                    for (int i = 0; i < quantities.Length; i++)
                    {
                        int val = quantities[i].Summ();
                        if (val > max)
                        {
                            imax = i;
                        }
                    }


                    Console.Write(imin + " ");
                    quantities[imax].PrintQuantity();



                    Console.WriteLine();
                    Console.WriteLine("----------b----------");
                    Console.WriteLine();

                    for (int i = 0; i < quantities.Length; i++)
                    {
                        if (quantities[i].IsLessZero())
                        {
                            quantities[i].PrintQuantity();
                        }
                    }

                    break;

                case 2:


                    Book book1 = new Book();
                    

                    break;



            }
        }
    }
}
        

 
