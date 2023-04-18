//Write a program to calculate Wind chill.
//Accept temperature (in Fahrenheit) and the wind speed as input and calculate wind chil using given formula.
//wind_chill = 35.74 + 0.6215 * temp + (0.4275 * temp - 35.75) * wind_speed ^ 0.16
//For ex :
//1) Suppose temp 20 and wind speed is 7.
//wind_chill = 35.74 + 0.6215*20 + (0.4275*20 - 35.75) *7 ^ 0.16
//so wind_chill = 11.034900625509998
//2) Suppose temp 70 and wind speed is 15.
//wind_chill = 35.74 + 0.6215*70 + (0.4275*70 - 35.75) *15 ^ 0.16
//so wind_chill = 70.26098370128452


using System;

namespace _18_WindChill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please provide temperature");
            //double temp = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please provide wind speed");
            //double windSpeed = int.Parse(Console.ReadLine());
            //var windChill = WindChill.Calculate(temp, windSpeed);
            //Console.WriteLine("windchill = " + windChill);
            double temp, wind_speed, wind_chill = 0;

            Console.WriteLine("Enter temperature and wind Speed:");

            temp = double.Parse(Console.ReadLine());
            wind_speed = double.Parse(Console.ReadLine());
            Console.WriteLine(temp + ":");
            Console.WriteLine(wind_speed + ":");

            wind_chill = WindChill.Calculate(temp, wind_speed);

            Console.WriteLine("Wind Chill is:");
            Console.WriteLine(wind_chill);
        }
    }

    public class WindChill
    {
        public static double Calculate(double temp, double windSpeed)
        {
            double result = 0;
            result = 35.74 + 0.6215 * temp + (-35.75 *Math.Pow(windSpeed,0.16)) + 0.4275 * temp * Math.Pow(windSpeed,0.16);
            return result;
        }
    }
}
