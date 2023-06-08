using System;
using System.Globalization;

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
        public static DateTime ShowLocalTime(DateTime dtUtc) => dtUtc.ToLocalTime();

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

        public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel) =>
            alertLevel switch
            {
                AlertLevel.Early => appointment.AddDays(-1),
                AlertLevel.Standard => appointment.AddMinutes(-105),
                AlertLevel.Late => appointment.AddMinutes(-30),
                _ => throw new ArgumentException()
            };

        public static bool HasDaylightSavingChanged(DateTime dt, Location location)
        {
            var result = false;
            TimeZoneInfo timeZoneObject = GetTimeZoneObject(location);

            for (DateTime date = dt.AddDays(-7); date <= dt.AddDays(7); date = date.AddDays(1))
            {
                if (timeZoneObject.IsDaylightSavingTime(date))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        public static DateTime NormalizeDateTime(string dtStr, Location location)
        {
            bool dateTimeStringParseSuccess = DateTime.TryParse(dtStr,
                    GetCultureInfo(location),
                    System.Globalization.DateTimeStyles.None
                    , out var dt);
            return dateTimeStringParseSuccess ? dt : new(1, 1, 1);
        }

        #region helperfunctions
        private static TimeZoneInfo GetTimeZoneObject(Location location) => location switch
        {
            Location.NewYork => TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"),
            Location.London => TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time"),
            Location.Paris => TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time"),
            _ => throw new ArgumentException()
        };
        
         private static CultureInfo GetCultureInfo(Location location) => location switch 
         {
             Location.NewYork => CultureInfo.GetCultureInfo("en-US"),
             Location.London => CultureInfo.GetCultureInfo("en-GB"),
             Location.Paris => CultureInfo.GetCultureInfo("fr-FR")
         };
        #endregion
    }

}