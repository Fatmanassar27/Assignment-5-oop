using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Duration
    {

        public int Hours   { get; set; }
       public int Minutes { get; set; }
       public int Seconds { get; set; }
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration()
        {
            
        }
        public Duration(int x)
        {
            Hours   = x / 3600;
            Minutes = (x % 3600 ) / 60;
            Seconds = (x % 3600) % 60;
        }

        //Override All System.Object Members (ToString, Equals,GetHasCode) 
        public override string ToString()
        {
            return $"Hours: {Hours}, Minutes :{Minutes}, Seconds :{Seconds}";
        }

        public override int GetHashCode()
        {
            Console.WriteLine($"HC : {base.GetHashCode()}");
            return base.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            Duration duration = (Duration)obj;
            if (duration.Hours == this.Hours && duration.Minutes == Minutes && duration.Seconds == Seconds) 
                return true;
            else
                return false;
        }

        // ●	D3=D1+D2
        public static Duration operator + ( Duration D1, Duration D2 )
        {
            Duration D3 = new Duration()
            {
                Hours=D1.Hours + D2.Hours,
                Minutes=D1.Minutes + D2.Minutes,
                Seconds=D1.Seconds + D2.Seconds
            };
            return D3;
        }

        // ●	D3=D1 + 7800
        public static Duration operator +(Duration D1, int x)
        {
            Duration D3 = new Duration()
            {
                Hours   = D1.Hours   +  x / 3600 ,           
                Minutes = D1.Minutes +  (x % 3600 ) / 60 ,
                Seconds = D1.Seconds +  (x % 3600) % 60 ,
            };
            return D3;
        }
        // ●	D3=666+D3
        public static Duration operator +(int x , Duration D1)
        {
            Duration D3 = new Duration()
            {
                Hours   = D1.Hours   + x / 3600,
                Minutes = D1.Minutes + (x % 3600 ) / 60,
                Seconds = D1.Seconds + (x % 3600) % 60,
            };
            return D3;
        }

        // D3= ++D1 (Increase One Minute)
        public static Duration operator ++ ( Duration d)
        {
            d.Minutes ++;
            return d;
        }

        // D3 = --D2 (Decrease One Minute)
        public static Duration operator -- (Duration d)
        {
            d.Minutes--;
            return d;
        }

        // D1= D1 -D2
        public static Duration operator - (Duration D1, Duration D2)
        {
            Duration D3 = new Duration()
            {
                Hours = D1.Hours - D2.Hours,
                Minutes = D1.Minutes - D2.Minutes,
                Seconds = D1.Seconds - D2.Seconds
            };
            return D3;
        }
        // If (D1>D2)
        public static bool operator > (Duration D1, Duration D2)
        {
            if (D1.Hours > D2.Hours)
            { return true ; }
            else if (D1.Hours < D2.Hours)
            { return false; }
            else
            {
                if (D1.Minutes > D2.Minutes)
                { return true; }
                else if (D1.Minutes < D2.Minutes)
                { return false; }
                else
                {
                    if (D1.Seconds > D2.Seconds)
                    { return true; }
                    else
                    { return false; }
                }
            }
        }

        public static bool operator < (Duration D1, Duration D2)
        {
            if (D1.Hours < D2.Hours)
            { return true; }
            else if (D1.Hours > D2.Hours)
            { return false; }
            else
            {
                if (D1.Minutes < D2.Minutes)
                { return true; }
                else if (D1.Minutes > D2.Minutes)
                { return false; }
                else
                {
                    if (D1.Seconds < D2.Seconds)
                    { return true; }
                    else
                    { return false; }
                }
            }
        }
        // If (D1<=D2)
        public static bool operator <=(Duration D1, Duration D2)
        {
            if (D1.Hours <= D2.Hours)
            { return true; }
            else if (D1.Hours >= D2.Hours)
            { return false; }
            else
            {
                if (D1.Minutes <= D2.Minutes)
                { return true; }
                else if (D1.Minutes >= D2.Minutes)
                { return false; }
                else
                {
                    if (D1.Seconds <= D2.Seconds)
                    { return true; }
                    else
                    { return false; }
                }
            }
        }
        public static bool operator >=(Duration D1, Duration D2)
        {
            if (D1.Hours >= D2.Hours)
            { return true; }
            else if (D1.Hours <= D2.Hours)
            { return false; }
            else
            {
                if (D1.Minutes >= D2.Minutes)
                { return true; }
                else if (D1.Minutes <= D2.Minutes)
                { return false; }
                else
                {
                    if (D1.Seconds >= D2.Seconds)
                    { return true; }
                    else
                    { return false; }
                }
            }
        }
        // If (D1)
        public static implicit operator bool(Duration d)
        {
            if (d.Hours == 0 && d.Minutes == 0 && d.Seconds ==0)
                { return false; }
            else { return true; }
        }
        // DateTime Obj = (DateTime) D1

        public static explicit operator DateTime (Duration d)
        {
            return new DateTime(d.Hours, d.Minutes, d.Seconds);
        }

    }
}
