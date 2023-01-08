using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discriminan
{
    internal static class Function
    {
        public static void show(double a, double b, double c)
        {
            if (b >= 0 && c >= 0)
                Console.WriteLine(a.ToString() + "x^2 " + "+ " + b.ToString() + "x " + "+ " + c.ToString() + " = 0");
            else if (b < 0 && c < 0)
                Console.WriteLine(a.ToString() + "x^2 " + b.ToString() + "x " + c.ToString() + " = 0");
            else if (b >= 0 && c < 0)
                Console.WriteLine(a.ToString() + "x^2 " + "+ " + b.ToString() + "x " + c.ToString() + " = 0");
            else
                Console.WriteLine(a.ToString() + "x^2 " + b.ToString() + "x " + "+ " + c.ToString() + " = 0");
        }

        public static double D(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }

        public static complexNumber solution1(double a, double b,  double d)
        {
            complexNumber temp;
            if (d >= 0)
                return temp = new complexNumber((b + Math.Sqrt(d)) / (2 * a), 0);

            else 
                return temp = new complexNumber((b / (2 * a)), Math.Sqrt(-d) / (2 * a));
        }

        public static complexNumber solution2(double a, double b, double d)
        {
            complexNumber temp;
            if (d >= 0)
                return temp = new complexNumber((b - Math.Sqrt(d)) / (2 * a), 0);

            else
                return temp = new complexNumber((b / (2 * a)), -Math.Sqrt(-d) / (2 * a));
        }
    }
}
