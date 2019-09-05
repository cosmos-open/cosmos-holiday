using System;
using System.Globalization;
using Cosmos.Business.Extensions.Holiday.Core.Globalization;

namespace Cosmos.Business.Extensions.Holiday.Core.Helpers
{
    internal static class HijriCalendarExtensions
    {
        public static DateTime ToDateTime(this HijriCalendar calendar, int year, IslamicMonths month, int day)
        {
            return calendar.ToDateTime(year, (int) month, day, 0, 0, 0, 0);
        }

        public static DateTime ToDateTime(this HijriCalendar calendar, int year, (IslamicMonths Month, int Day) date)
        {
            return calendar.ToDateTime(year, (int) date.Month, date.Day, 0, 0, 0, 0);
        }
    }
}