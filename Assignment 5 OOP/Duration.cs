using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_OOP
{
    internal class Duration
    {

        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }


        #region Constructors
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration(int seconds)
        {
            Hours = seconds / 3600;

            Minutes = (seconds % 3600) / 60;

            Seconds = (seconds % 3600) % 60;

        } 
        #endregion

        #region Override

        public override string ToString()
        {
            return $"Duration: {Hours} Hours, {Minutes} Minutes, {Seconds} Seconds";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != typeof(Duration))
            {
                return false;
            }

            Duration other = (Duration)obj;
            return Hours == other.Hours &&
                   Minutes == other.Minutes &&
                   Seconds == other.Seconds;

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
        #endregion

        #region Operators overloading

        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(
                d1.Hours + d2.Hours,
                d1.Minutes + d2.Minutes,
                d1.Seconds + d2.Seconds
            );
        }

        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(
                d.Hours,
                d.Minutes,
                d.Seconds + seconds
            );
        }

        public static Duration operator +(int seconds, Duration d)
        {
            return d + seconds;
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            int totalSeconds1 = d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds;
            int totalSeconds2 = d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds;

            return new Duration(totalSeconds1 - totalSeconds2);
        }

        public static Duration operator ++(Duration d)
        {
            return d + 60;
        }

        public static Duration operator --(Duration d)
        {
            return d - new Duration(60);
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) >
                   (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) <
                   (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1 > d2 || d1 == d2;
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1 < d2 || d1 == d2;
        }


        public static implicit operator bool(Duration d)
        {
            return (d.Hours > 0 || d.Minutes > 0 || d.Seconds > 0);
        }

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }

        #endregion

    }
}
