using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discriminan
{
    internal class complexNumber
    {
        public double A { get; }
       public double B { get; private set; }

        public complexNumber()
        {
            A = 0;
            B = 0;
        }

        public complexNumber(double a, double b)
        {
            A = a;
            B = b;
        }

        public override bool Equals(object o)
        {
            complexNumber temp = o as complexNumber;

            if (temp == null)
                return false;
            else
                return this.A == temp.A && this.B == temp.B;
        }

        public override string ToString()
        {
            if (B == 0)
                return A.ToString();
            else if (A == 0)
                return B.ToString() + "i";
            else
                if (B > 0)
                return A.ToString() + " + " + B.ToString() + "i";
            else
            {
                B = -B;
                return A.ToString() + " - " + B.ToString() + "i";
            }
                
        }

        public override int GetHashCode()
        {
            return (int)A ^ (int)B;
        }

        public static complexNumber operator +(complexNumber a, complexNumber b)
        {
           complexNumber c = new complexNumber(a.A + b.A, a.B + b.B);
            return c;
        }

        public static complexNumber operator -(complexNumber a, complexNumber b)
        {
            complexNumber c = new complexNumber(a.A - b.A, a.B - b.B);
            return c;
        }

        public static bool operator ==(complexNumber a, complexNumber b)
        {
            return a.A == b.A && a.B == b.B;
        }

        public static bool operator !=(complexNumber a, complexNumber b)
        {
            return a.A != b.A || a.B != b.B;
        }

        public static complexNumber operator *(complexNumber a, complexNumber b)
        {
            complexNumber c = new complexNumber(a.A * b.A + a.B * b.B, a.A * b.B + a.B * b.A);
            return c;
        }

        public static complexNumber operator /(complexNumber a, complexNumber b)
        {
            complexNumber c = new complexNumber((a.A * b.A + a.B * (-b.B)) / (b.A * b.A - b.B * b.B),
                                                ((a.B * b.A + a.A * (-b.B)) / (b.A * b.A - b.B * b.B)));
            return c;
        }
    }
}
