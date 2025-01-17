using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_OOP
{
    internal class Maths
    {
        //static because we don't need object to call these methods
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                return -99999999;
                
            }else return a / b;
        }
    }
}
