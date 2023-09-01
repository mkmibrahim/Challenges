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
        First = 1,
        Second = 2,
        Third = 3,
        Fourth = 4,
        Last
    }

    public class Meetup
    {
        private int _month, _year;
        public Meetup(int month, int year)
        {
            _month = month;
            _year = year;
        }

        public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
        {
            DateTime day;
            switch (schedule)
            {
                case Schedule.Teenth:
                    day = getTeenth(dayOfWeek);
                    break;
                case Schedule.First:
                case Schedule.Second:
                case Schedule.Third:
                case Schedule.Fourth:
                    day = getDay(dayOfWeek, schedule);
                    break;
                default:
                    throw new ArgumentException();
                    break;
            }
             
            return day;
        }

        private DateTime getDay(DayOfWeek dayOfWeek, Schedule schedule)
        {
            var daysInMonth = DateTime.DaysInMonth(_year, _month);
            var dayOfWeekOccured = 0;
            for (int i = 1; i <= daysInMonth; i++)
            {
                var currentDay = new DateTime(_year, _month, i);
                if (currentDay.DayOfWeek == dayOfWeek)
                {
                    dayOfWeekOccured++;
                    if (dayOfWeekOccured == (int)schedule)
                        return currentDay;
                }
            }
            throw new ArgumentException();
        }

        private DateTime getFirst(DayOfWeek dayOfWeek)
        {
            for (int i = 1; i < 8; i++)
            {
                var currenDatetime = new DateTime(_year, _month, i);
                if (currenDatetime.DayOfWeek == dayOfWeek)
                    return currenDatetime;
            }
            throw new ArgumentException();
        }

        private DateTime getTeenth(DayOfWeek dayOfWeek)
        {
            for (int i = 13; i < 20; i++)
            {
                var currentDay = new DateTime(_year, _month, i);
                if (currentDay.DayOfWeek == dayOfWeek)
                    return currentDay;
            }

            throw new ArgumentException();
        }
    }
}