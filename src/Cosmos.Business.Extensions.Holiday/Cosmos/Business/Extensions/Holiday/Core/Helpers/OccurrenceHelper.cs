using System;

namespace Cosmos.Business.Extensions.Holiday.Core.Helpers
{
    internal static class OccurrenceHelper
    {
        public static DateTime FindOccurrenceOfDayOfWeek(DateTime dt, DayOfWeek day, short occurance)
        {
            while (dt.DayOfWeek != day)
                dt = dt.AddDays(1);

            dt = dt.AddDays(7 * (occurance - 1));

            return dt;
        }

        public static DateTime FindNearestDayOfWeek(DateTime dt, DayOfWeek day)
        {
            int advance = 0;
            while (((int) dt.DayOfWeek + advance) % 7 != (int) day)
                advance++;

            if (advance > 3)
                return dt.AddDays(advance - 7);
            else return dt.AddDays(advance);
        }
    }
}