//Write a program which takes input length and width of rectangle as integer and print the rectangle.

//    Example:
//1.If width = 10 and height = 5 then the rectangle is :

//**********
//    **
//    **
//    **
//**********

//  1.If width = 15 and height = 10 then the rectangle is :

//***************
//    **
//    **
//    **
//    **
//    **
//    **
//    **
//    **
// ***************

using System;

namespace _08_PrintRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int l, w;
            Console.WriteLine("Enter the length:");
            l = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width:");
            w = int.Parse(Console.ReadLine());

            //Write your logic here
            WriteStars(l);
            for (int i = 0; i < w - 2; i++)
            {
                Console.Write('*');
                for (int j = 0; j < l - 2; j++)
                {
                    Console.Write(' ');
                }
                Console.Write('*');
                Console.WriteLine();
            }
            WriteStars(l);
            Console.ReadLine();
            //end
        }

        private static void WriteStars(int w)
        {
            for (int i = 0; i < w; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
    }
}
