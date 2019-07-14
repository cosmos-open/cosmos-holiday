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
                    return dt.SaturdayShift(saturday);

                case DayOfWeek.Sunday:
                    return dt.SundayShift(sunday);

                case DayOfWeek.Monday:
                    return dt.MondayShift(monday);
            }

            return dt;
        }

        public static DateTime SundayShift(this DateTime dt, Func<DateTime, DateTime> func)
        {
            if (dt.DayOfWeek == DayOfWeek.Sunday)
                return func?.Invoke(dt) ?? dt;
            return dt;
        }

        public static DateTime MondayShift(this DateTime dt, Func<DateTime, DateTime> func)
        {
            if (dt.DayOfWeek == DayOfWeek.Monday)
                return func?.Invoke(dt) ?? dt;
            return dt;
        }

        public static DateTime TuesdayShift(this DateTime dt, Func<DateTime, DateTime> func)
        {
            if (dt.DayOfWeek == DayOfWeek.Tuesday)
                return func?.Invoke(dt) ?? dt;
            return dt;
        }

        public static DateTime WednesdayShift(this DateTime dt, Func<DateTime, DateTime> func)
        {
            if (dt.DayOfWeek == DayOfWeek.Wednesday)
                return func?.Invoke(dt) ?? dt;
            return dt;
        }

        public static DateTime ThursdayShift(this DateTime dt, Func<DateTime, DateTime> func)
        {
            if (dt.DayOfWeek == DayOfWeek.Thursday)
                return func?.Invoke(dt) ?? dt;
            return dt;
        }
        
        public static DateTime FridayShift(this DateTime dt, Func<DateTime, DateTime> func)
        {
            if (dt.DayOfWeek == DayOfWeek.Friday)
                return func?.Invoke(dt) ?? dt;
            return dt;
        }


        public static DateTime SaturdayShift(this DateTime dt, Func<DateTime, DateTime> func)
        {
            if (dt.DayOfWeek == DayOfWeek.Saturday)
                return func?.Invoke(dt) ?? dt;
            return dt;
        }
    }
}