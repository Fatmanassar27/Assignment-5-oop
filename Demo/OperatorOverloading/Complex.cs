using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.OperatorOverloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imagin { get; set; }

        public override string ToString()
        {
            return $"( {Real} + {Imagin}i )";
        }

        #region Binary Operator OverLoading 
        public static Complex operator + (Complex x, Complex y)
        {
            Complex complex = new Complex();
            complex.Real = (x?.Real ?? 0) + (y?.Real ?? 0);
            complex.Imagin = (x?.Imagin ?? 0) + (y?.Imagin ?? 0);
            return complex ;
        }

        public static Complex operator -(Complex x, Complex y)
        {
            Complex complex = new Complex();
            complex.Real = (x?.Real ?? 0) - (y?.Real ?? 0);
            complex.Imagin = (x?.Imagin ?? 0) - (y?.Imagin ?? 0);
            return complex;
        }

        #endregion

        #region Unary Operator OverLoading 
        public static Complex operator ++ (Complex x)
        {
            Complex complex = new Complex();
            complex.Real = (x?.Real ?? 0) + 1;
            complex.Imagin = (x?.Imagin ?? 0) ;
            return complex;
        }
        
        public static Complex operator -- (Complex x)
        {
            Complex complex = new Complex();
            complex.Real = (x?.Real ?? 0) - 1;
            complex.Imagin = (x?.Imagin ?? 0) ;
            return complex;
        }
        #endregion

        #region Reational Operator OverLoading
        public static bool operator > (Complex x, Complex y)
        {
            if (x.Real == y.Real)
               return x.Imagin > y.Imagin;
            else
                return x.Real > y.Real;
        }
        public static bool operator < (Complex x, Complex y)
        {
            if (x.Real == y.Real)
               return x.Imagin < y.Imagin;
            else
                return x.Real < y.Real;
        }
        #endregion

        #region Casting Operator overloading

        public static explicit operator int (Complex x)
            { return x?.Real ?? 0; }
        
        public static implicit operator string (Complex x)
            { return x?.ToString() ?? string.Empty; }

        #endregion

    }
}
