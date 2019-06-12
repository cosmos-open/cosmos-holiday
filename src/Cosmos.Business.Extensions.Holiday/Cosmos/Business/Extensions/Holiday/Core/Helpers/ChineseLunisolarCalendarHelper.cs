using System.Globalization;

namespace Cosmos.Business.Extensions.Holiday.Core.Helpers
{
    internal static class ChineseLunisolarCalendarHelper
    {
        public static readonly ChineseLunisolarCalendar Instance = new ChineseLunisolarCalendar();

        public static int MoveMonth(int month, int leapMonth)
        {
            if (leapMonth == 0)
                return month;

            if (leapMonth < month)
                return ++month;

            return month;
        }
    }
}