using System;

namespace _26_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public enum Location
    {
        NewYork,
        London,
        Paris
    }

    public enum AlertLevel
    {
        Early,
        Standard,
        Late
    }

    public static class Appointment
    {
        public static DateTime ShowLocalTime(DateTime dtUtc)
        {
            return dtUtc.ToLocalTime();
        }

        public static DateTime Schedule(string appointmentDateDescription, Location location)
        {
            if (DateTime.TryParse(appointmentDateDescription, 
                System.Globalization.CultureInfo.GetCultureInfo("en-US"),
                System.Globalization.DateTimeStyles.None
                ,out var date))
            {
                TimeZoneInfo timeZoneObject = GetTimeZoneObject(location);

                var utcDateTime = TimeZoneInfo.ConvertTimeToUtc(date, timeZoneObject);
                return utcDateTime;
            }
            else 
                throw new ArgumentException();
        }

        public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel)
        {
            if (alertLevel.Equals(AlertLevel.Early))
                return appointment.AddDays(-1);
            if (alertLevel.Equals(AlertLevel.Standard))
                return appointment.AddMinutes(-45);
            if (alertLevel.Equals(AlertLevel.Late))
                return appointment.AddMinutes(-30);
            else
                throw new Exception();
        }

        public static bool HasDaylightSavingChanged(DateTime dt, Location location)
        {
            var result = false;
            var timeZoneObject = GetTimeZoneObject(location);
            var adjustmentRules = timeZoneObject.GetAdjustmentRules();
            foreach (TimeZoneInfo.AdjustmentRule adjustmentRule in adjustmentRules)
            {
                if ((adjustmentRule.DateStart - dt <= TimeSpan.FromDays(7)) ||
                    dt - adjustmentRule.DateStart <= TimeSpan.FromDays(7))
                    result = true;
            }
            return result;
        }

        public static DateTime NormalizeDateTime(string dtStr, Location location)
        {
            DateTime dt = new DateTime();
            if (location.Equals(Location.NewYork))
                DateTime.TryParse(dtStr, 
                    System.Globalization.CultureInfo.GetCultureInfo("en-US"),
                    System.Globalization.DateTimeStyles.None
                    ,out dt);
            else if (location.Equals(Location.London))
                DateTime.TryParse(dtStr, 
                    System.Globalization.CultureInfo.GetCultureInfo("en-GB"),
                    System.Globalization.DateTimeStyles.None
                    ,out dt);
            else 
                DateTime.TryParse(dtStr, 
                    System.Globalization.CultureInfo.GetCultureInfo("fr-FR"),
                    System.Globalization.DateTimeStyles.None
                    ,out dt);
            return dt;
        }

        #region helperfunctions
        private static TimeZoneInfo GetTimeZoneObject(Location location)
        {
            TimeZoneInfo timeZoneObject;
            switch (location)
            {
                case Location.NewYork:
                    timeZoneObject = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
                    break;
                case Location.London:
                    timeZoneObject = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
                    break;
                default:
                    timeZoneObject = TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time");
                    break;
            }

            return timeZoneObject;
        }

        #endregion
    }

}