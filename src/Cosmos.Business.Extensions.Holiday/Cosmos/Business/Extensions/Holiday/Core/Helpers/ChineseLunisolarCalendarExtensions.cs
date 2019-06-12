using System;
using System.Collections.Concurrent;
using System.Globalization;

namespace Cosmos.Business.Extensions.Holiday.Core.Helpers
{
    internal static class ChineseLunisolarCalendarExtensions
    {
        public static DateTime ToDateTime(this ChineseLunisolarCalendar calendar, int year, int month, int day)
        {
            return calendar.ToDateTime(year, month, day, 0, 0, 0, 0);
        }

        private static ConcurrentDictionary<int, int> LeapMonthCache = new ConcurrentDictionary<int, int>();

        public static int GetLeapMonthAndCache(this ChineseLunisolarCalendar calendar, int year)
        {
            if (LeapMonthCache.TryGetValue(year, out int result))
                return result;
            result = calendar.GetLeapMonth(year);
            LeapMonthCache.TryAdd(year, result);
            return result;
        }
    }
}