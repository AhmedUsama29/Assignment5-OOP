using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_OOP
{
    internal class Point3D
    {

        #region Attributes
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; } 
        #endregion

        #region Constructors

        public Point3D()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public Point3D(int x)
        {
            X = x;
            Y = 0;
            Z = 0;
        }

        public Point3D(int x, int y) : this(x)
        {
            Y = y;
            Z = 0;
        }

        public Point3D(int x, int y, int z) : this(x, y)
        {
            Z = z;
        }
        #endregion

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }



    }
}
