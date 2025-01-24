using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopassig6
{
    internal class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point3D()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
        public Point3D(int x,int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
           
        }
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }
        public override bool Equals(object obj)
        {
            if (obj is Point3D other)
            {
                return X == other.X && Y == other.Y && Z == other.Z;
            }
            return false;
        }
        public static bool operator ==(Point3D p1, Point3D p2)
        {
            if (p1 is null && p2 is null) return true;
            if (p1 is null || p2 is null) return false;
            return p1.Equals(p2);
        }
        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !(p1 == p2);
        }
        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }
    }

}

