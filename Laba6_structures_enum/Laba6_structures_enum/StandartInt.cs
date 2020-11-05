using System;
using System.Collections.Generic;
using System.Text;

namespace Laba6_structures_enum
{
    class workClass : IComparer<workClass>, IComparable, ICloneable
    {

        public workClass(int value)
        {
            field = value;
        }

        public int field;
        public int CompareTo(object obj)
        {
           workClass temp = (workClass)obj;

            if (this.field > temp.field) return 1;

            if (this.field < temp.field) return -1;

            return 0;

        }
       public int Compare(workClass obj1, workClass obj2)
        {
            
            if (obj1.field > obj2.field) return 1;

            if (obj1.field < obj2.field) return -1;

            return 0;
            
        }


        public workClass ShallowClone()

        {

            return (workClass)this.MemberwiseClone();
        }

        public object Clone()

        {

            return new workClass(this.field);

        }



    }


  

}
   











