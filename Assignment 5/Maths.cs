using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public static class Maths
    {
       public static int Add (int a, int b)
            { return a + b; }
       public static int Subtract (int a, int b)
            { return a - b; }
       public static int Multiply (int a, int b)
            { return a * b; }
       public static double Divide(int a, double b)
            {
               if (b != 0)
                   return a / b;
               else
                   return -1;
            }
    }
}
