using System;
using System.Collections.Generic;
using System.Text;

namespace Laba8_generic
{
    interface IGeneric<T>
    {
      public void Add(T obj);
      public void Delete(T obj);
      public void Show(T obj);
    }
}
