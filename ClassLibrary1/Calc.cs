using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Calc
    {
        public static double Summary(double first, double second)
        {
            return first + second;
        }

        public static double Minus(double first, double second)
        {
            return first - second;
        }

        public static double Multiply(double first, double second)
        {
            return first * second;
        }

        public static double Division(double first, double second)
        {
            return first / second;
        }
    }
}
