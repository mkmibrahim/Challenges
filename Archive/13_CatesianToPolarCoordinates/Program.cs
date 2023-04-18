//Write a program which accepts cartesian coordinates x and y, and prints its polar coordinates form i.e. r and theta (degrees only).

//    For ex :
//1) if user input x = 3 and y = 5 then it should print r and theta as
//5.8309
//59.0362

//2) if user input x = 20 and y = 34 then it should print r and theta as
//39.4462
//59.5345

using System;
// ReSharper disable InconsistentNaming

namespace _13_CatesianToPolarCoordinates
{
    class Program
    {
        static void Main()
        {
            double x, y ;
            double r, theta;

            Console.WriteLine("Enter x co-ordinate:");
            x = double.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Enter y co-ordinate:");
            y = double.Parse(Console.ReadLine() ?? string.Empty);


            Console.WriteLine(x + ":");
            Console.WriteLine(y + ":");


            /*
                   Your logic goes here
                */
            var result = CartesianToPolar.Convert(new CartesianToPolar.CartesianCoordinate{x = 3,y = 5});
            r = result.r;
            theta = result.theta;


            Console.WriteLine("r and theta are:");
            Console.WriteLine(r);
            Console.WriteLine(theta);

        }
    }

    public class CartesianToPolar
    {
        public struct PolarPoint
        {
            public double r;
            public double theta;
        }

        public struct CartesianCoordinate
        {
            public double x;
            public double y;
        }


        public static PolarPoint Convert(CartesianCoordinate cartesianCoordinate)
        {
            PolarPoint result = new PolarPoint();
            PolarPoint polartPoint = new PolarPoint();
            polartPoint.r = Math.Sqrt((cartesianCoordinate.x*cartesianCoordinate.x) +
                                      (cartesianCoordinate.y*cartesianCoordinate.y));
            var radians = Math.Atan2(cartesianCoordinate.y, cartesianCoordinate.x);
            polartPoint.theta = radians * (180 / Math.PI);

            //MidpointRounding may not be used
            result.r = Math.Round(polartPoint.r, 4, MidpointRounding.ToZero);
            //result.r = Math.Floor(polartPoint.r * 10000) / 10000; 
            result.theta = Math.Round(polartPoint.theta, 4, MidpointRounding.ToZero);
            return result;
        }
    }
}
