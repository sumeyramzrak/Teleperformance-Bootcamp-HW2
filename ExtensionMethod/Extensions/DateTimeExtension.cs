using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class DateTimeExtension
    {
        public static void DateDiff(this DateTime date)
        {
            var today = DateTime.Now;
            TimeSpan span = today.Subtract(date);
            if (span.TotalDays > 0)
            {
                Console.WriteLine($"{Math.Round(span.TotalDays, 0)} gün {Math.Round(span.TotalHours%24, 0)} saat {Math.Round(span.TotalMinutes % 60, 0)} dakika önce");
            }
            else
            {
                Console.WriteLine($"{Math.Round(span.TotalDays, 0) * -1} gün {Math.Round(span.TotalHours % 24, 0) * -1} saat {Math.Round(span.TotalMinutes % 60, 0) * -1} dakika sonra");
            }
               
        }
    }
}
