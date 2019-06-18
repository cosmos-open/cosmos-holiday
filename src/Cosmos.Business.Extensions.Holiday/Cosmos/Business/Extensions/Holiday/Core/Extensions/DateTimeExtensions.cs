using System;

namespace Cosmos.Business.Extensions.Holiday.Core.Extensions
{
    internal static class DateTimeExtensions
    {
        public static DateTime Shift(
            this DateTime dt,
            Func<DateTime, DateTime> saturday,
            Func<DateTime, DateTime> sunday,
            Func<DateTime, DateTime> monday = null)
        {
            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                    return saturday.Invoke(dt);

                case DayOfWeek.Sunday:
                    return sunday.Invoke(dt);

                case DayOfWeek.Monday:
                    if (monday != null)
                        return monday.Invoke(dt);
                    break;
            }

            return dt;
        }
    }
}