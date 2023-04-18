//Write a program which accepts an Integer which is an Angle and prints the Quadrant number in which it is.

//For Ex.
//1) if user input 30 then it should print 1.
//2) if user input 197 then it should print 3.
using System;

namespace _28_QuadrantOfAnAngle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type an integer angle (in degrees) and press Enter:");
            int angle = int.Parse(Console.ReadLine());
            Console.WriteLine(angle + ":");
            
            Console.WriteLine("Quadrant is:");
            var quadrant = QuadrantOfAnAngle.GetQuadrant(angle);
            Console.WriteLine(quadrant);
        }
    }

    public class QuadrantOfAnAngle
    {
        public static int GetQuadrant(int angle) 
        {
            if (angle <= 90)
                return 1;
            else if (angle <= 180)
                return 2;
            else if (angle <= 270)
                return 3;
            else
                return 4;
        }
    }
}
