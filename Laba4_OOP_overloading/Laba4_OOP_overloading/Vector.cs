using System;
using System.Collections.Generic;
using System.Text;

namespace Laba4_OOP_overloading
{
    public class Vector
    {

        public Owner user = new Owner(15, "Никита", "БГТУ");

      public class Date
        {
            public string date = DateTime.Now.ToString();
        }

        public Date date=new Date();
        


        public int x, y;
        public Vector()
        {
            x = 0;
            y = 0;
            
        }
        public Vector(int x, int y)
        {
            this.x = x;
            this.y = y;
            
        }
        public static Vector operator +(Vector Vector, Vector Vector1)
        {

            return new Vector(Vector.x + Vector1.x, Vector.y + Vector1.y);
        }
        public static bool operator >(Vector Vector, Vector Vector1)
        {
            if (Vector.x * Vector.y > Vector1.x * Vector.y) return true;
            else return false;
        }
        public static bool operator <(Vector Vector, Vector Vector1)
        {
            if (Vector.x * Vector.y < Vector1.x * Vector.y) return true;
            else return false;
        }
        public static Vector operator ==(Vector Vector, Vector Vector1)
        {
            Vector1.x = Vector.x;
            Vector1.y = Vector.y;
            return Vector1;
        }
        public static Vector operator !=(Vector Vector, Vector Vector1)
        {
            Vector1.x = Vector.x;
            Vector1.y = Vector.y;
            return Vector1;

        }
        public static bool operator true(Vector Vector)
        {
            if (Vector.x == 0 && Vector.y == 0) return true;
            else return false;
        }
        public static bool operator false(Vector Vector)
        {
            if (Vector.x != 0 && Vector.y != 0) return true;
            else return false;
        }
    }
}
