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
            throw new NotImplementedException("You need to implement this extension method.");
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

        //public RationalNumber(int numerator, int denominator)
        //{
        //}

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
            int lcm = LCM(r1.Denominator, r2.Denominator);
            int num1 = r1.Numerator * (lcm / r1.Denominator);
            int num2 = r2.Numerator * (lcm / r2.Denominator);
            return new RationalNumber(num1 + num2, lcm).Reduce();
        }

        public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
        {
            int lcm = LCM(r1.Denominator, r2.Denominator);
            int num1 = r1.Numerator * (lcm / r1.Denominator);
            int num2 = r2.Numerator * (lcm / r2.Denominator);
            return new RationalNumber(num1 - num2, lcm).Reduce();
        }

        public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
        {
            int num = r1.Numerator * r2.Numerator;
            int den = r1.Denominator * r2.Denominator;
            return new RationalNumber(num, den).Reduce();
        }

        public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
        {
            int num = r1.Numerator * r2.Denominator;
            int den = r1.Denominator * r2.Numerator;
            return new RationalNumber(num, den).Reduce();
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