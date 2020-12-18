using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint1
{
    public class Fraction
    {
        private readonly int numerator;
        private readonly int denominator;

        public Fraction(int num, int den)
        {
            if (den == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.", nameof(denominator));
            }
            numerator = num;
            denominator = den;
        }

        public static Fraction operator +(Fraction a) => a.Simplify();
        public static Fraction operator -(Fraction aa)
        {
            Fraction a = aa.Simplify();
            return new Fraction(-a.numerator, a.denominator);
        }

        public static Fraction operator +(Fraction aa, Fraction bb)
        {
            Fraction a = aa.Simplify();
            Fraction b = bb.Simplify();
            return new Fraction(a.numerator * b.denominator + b.numerator * a.denominator, a.denominator * b.denominator);
        }
       
        public static Fraction operator -(Fraction aa, Fraction bb)
        {
            Fraction a = aa.Simplify();
            Fraction b = bb.Simplify();
            return a + (-b);
        }
           

        public static Fraction operator *(Fraction aa, Fraction bb)
        {
            Fraction a = aa.Simplify();
            Fraction b = bb.Simplify();
            return new Fraction(a.numerator * b.numerator, a.denominator * b.denominator);
        }
        

        public static Fraction operator /(Fraction aa, Fraction bb)
        {
            Fraction a = aa.Simplify();
            Fraction b = bb.Simplify();
            if (b.numerator == 0)
            {
                throw new DivideByZeroException();
            }
            return new Fraction(a.numerator * b.denominator, a.denominator * b.numerator);
        }
        public static Fraction operator !(Fraction f) => new Fraction(f.denominator, f.numerator);

        public override string ToString()
        {
            Fraction o = this.Simplify();
            Fraction obj = o.CorectSighn();
            return $"{obj.numerator} / {obj.denominator}";
        }
        static int gcd(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            int r = a % b;
            return gcd(b, r);
        }

        public Fraction Simplify()
        {
            int divisor = gcd(numerator, denominator);
            //Console.WriteLine("num = " + numerator + " den = " + denominator + "\n");
            //Console.WriteLine("divisor = " + divisor + "\n");
            if (divisor != 1)
            {
                return new Fraction(numerator / divisor, denominator / divisor);
            }
            return new Fraction(this.numerator, this.denominator);
        }

        public static bool operator ==(Fraction _obj1, Fraction _obj2)
        {
            Fraction obj1 = _obj1.Simplify();
            Fraction obj2 = _obj2.Simplify();
            return obj1.denominator == obj2.denominator && obj1.numerator == obj2.numerator;
        }
        public static bool operator !=(Fraction _obj1, Fraction _obj2)
        {
            Fraction obj1 = _obj1.Simplify();
            Fraction obj2 = _obj2.Simplify();
            return obj1.numerator != obj2.numerator || obj1.denominator != obj2.denominator;
        }

        public override bool Equals(Object _obj)
        {
            if ((_obj == null) || !this.GetType().Equals(_obj.GetType()))
            {
                return false;
            }
            else
            {
                Fraction o = this.Simplify();
                Fraction obj1 = (Fraction)_obj;
                Fraction obj = obj1.Simplify();
                return o.numerator == obj1.numerator && o.denominator == obj1.denominator;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public Fraction CorectSighn()
        {
            if (denominator < 0)
            {
                return new Fraction(numerator * (-1), denominator * (-1));
            }
            else return new Fraction(this.numerator, this.denominator);
        }
    }
}
