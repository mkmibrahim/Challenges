using System;

namespace _73_Meetup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    

    public enum Schedule
    {
        Teenth,
        First,
        Second,
        Third,
        Fourth,
        Last
    }

    public class Meetup
    {
        public Meetup(int month, int year)
        {
        }

        public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
        {
            throw new NotImplementedException("You need to implement this function.");
        }
    }
}