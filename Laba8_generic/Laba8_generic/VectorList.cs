using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Laba8_generic
{
    class VectorList<T> : IGeneric<T> where T : Vector
    {
        public string name { get; private set; }

        public VectorList(string inputName)
            {
            name=inputName;
            }

        private List<T> list=new List<T>();
        public void Add(T obj)
        {
            list.Add(obj);
        }

        public void Delete(T obj)
        {
            list.Remove(obj);
        }
        public void Show()
        {

            foreach (Vector i in list)
            {
                i.PrintVector();

            }
            Console.WriteLine();
            Console.WriteLine();


        }

        public void fielWrite()
        {
            foreach (Vector i in list)
            {

                await fstream.WriteAsync(array, 0, array.Length);
                Console.WriteLine("Текст записан в файл");
            }

        }
    }
}
