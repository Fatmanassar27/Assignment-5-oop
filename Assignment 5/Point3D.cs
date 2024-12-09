using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Point3D : ICloneable , IComparable 
    {

        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Point3D()
        {

        }
        public override string ToString()
        {
            return $"Point Coordinates: ({x}, {y}, {z})";
        }

        public object Clone()
        {
           return new Point3D ()
           {
               x = x,
               y = y,
               z = z
           };
        }

        public int CompareTo(object? obj)
        {
            Point3D point3D = (Point3D) obj;
            if (this.x > point3D.x && this.y >point3D.y)
                return 1;
            else if (this.x < point3D.x && this.y < point3D.y)
                return -1;
            else return 0;
        }

        public static bool operator ==(Point3D left, Point3D right)
        {
            if (left.x == right.x && left.y == right.y && left.z == right.z)
                return true;
            else
                return false;
        }
        public static bool operator !=(Point3D left, Point3D right)
        {
            if (left.x != right.x && left.y != right.y && left.z != right.z)
                return true;
            else
                return false;
        }


    }
}
