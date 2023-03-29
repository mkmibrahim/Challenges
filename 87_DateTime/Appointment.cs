using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Runtime.CompilerServices;
using System.Net.Http.Headers;

[assembly:InternalsVisibleTo("87_DateTime.Tests")]

namespace _87_DateTime
{
    

    static class Appointment
    {
        public static DateTime Schedule(string appointmentDateDescription)
        {
            DateTime result = DateTime.Parse(appointmentDateDescription,
                                    System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            return result;
            
        }

        public static bool HasPassed(DateTime appointmentDate)
        {
            if (appointmentDate < DateTime.Now)
                return true;
            else
                return false;
        }

        public static bool IsAfternoonAppointment(DateTime appointmentDate)
        {
            if (appointmentDate.Hour >= 12 & appointmentDate.Hour < 18)
                return true;
            else
                return false;

        }

        public static string Description(DateTime appointmentDate)
        {
            var result = "You have an appointment on " + appointmentDate.ToString("G", 
                System.Globalization.CultureInfo.GetCultureInfo("en-US")) +"."; 
            return result;
        }

        public static DateTime AnniversaryDate()
        {
            var result = new DateTime(DateTime.Now.Year, 9,15, 0, 0, 0);
            return result;
        }
    }
}
