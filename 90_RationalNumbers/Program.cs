using System;
using System.Diagnostics;


namespace _90_RationalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class RealNumberExtension
    {
        public static double Expreal(this int realNumber, RationalNumber r)
        {
            return r.Expreal(realNumber);
        }
    }

    public struct RationalNumber
    {
        public int Numerator { get; }
        public int Denominator { get; }

        public RationalNumber(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        private static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }

        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
        {
            return new(
                r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator,
                r1.Denominator * r2.Denominator);
        }

        public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
        {
            return new RationalNumber(
                r1.Numerator * r2.Denominator - r2.Numerator * r1.Denominator,
                r1.Denominator * r2.Denominator).Reduce();
        }

        public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
        {
            return new RationalNumber(
                r1.Numerator * r2.Numerator,
                r1.Denominator * r2.Denominator).Reduce();
        }

        public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
        {
            if (r2.Numerator == 0)
            {
                throw new DivideByZeroException();
            }
            return new RationalNumber(
                r1.Numerator * r2.Denominator,
                r1.Denominator * r2.Numerator);
        }

        public RationalNumber Abs()
        {
            return new RationalNumber(Math.Abs(Numerator), Math.Abs(Denominator)).Reduce();
        }

        public RationalNumber Reduce()
        {
            int gcd = GCD(Numerator, Denominator);
            return new RationalNumber(Numerator / gcd, Denominator / gcd);
        }

        public RationalNumber Exprational(int power)
        {
            int num = (int)Math.Pow(Numerator, power);
            int den = (int)Math.Pow(Denominator, power);
            return new RationalNumber(num, den).Reduce();
        }

        public double Expreal(int baseNumber)
        {
            double num = Math.Pow(baseNumber, Numerator);
            double den = Math.Pow(baseNumber, Denominator);
            return num / den;
        }
    }
}