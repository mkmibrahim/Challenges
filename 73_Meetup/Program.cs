namespace _73_Meetup
{
    internal class Program
    {
        static void Main()
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
        private int _month, _year;
        public Meetup(int month, int year)
        {
            _month = month;
            _year = year;
        }

        public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
        {
            DateTime day = default;
            switch (schedule)
            {
                case Schedule.Teenth:
                    day = GetTeenth(dayOfWeek);
                    break;
                case Schedule.First:
                case Schedule.Second:
                case Schedule.Third:
                case Schedule.Fourth:
                case Schedule.Last:
                    day = GetDay(dayOfWeek, schedule);
                    break;
            }
             
            return day;
        }

        private DateTime GetDay(DayOfWeek dayOfWeek, Schedule schedule)
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
                    if (schedule == Schedule.Last && daysInMonth - i < 7)
                        return currentDay;
                }
            }
            throw new ArgumentException();
        }

        private DateTime GetTeenth(DayOfWeek dayOfWeek)
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