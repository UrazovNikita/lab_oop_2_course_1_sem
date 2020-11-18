using System;
using System.Collections.Generic;
using System.Text;

namespace Laba8_generic
{
    class VectorList<T> : IGeneric<T>
    {
        public string name { get; private set; }

        public VectorList(string inputName)
            {
            name=inputName;
            }

        private List<T> list;
        public void Add(T obj)
        {
            list.Add(obj);
        }

        public void Delete(T obj)
        {
            list.Remove(obj);
        }
        public void Show(T obj)
        {
          
                

        }
    }
}
