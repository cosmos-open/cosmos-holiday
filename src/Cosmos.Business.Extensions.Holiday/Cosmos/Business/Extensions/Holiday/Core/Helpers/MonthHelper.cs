using System;
using Cosmos.Date;

namespace Cosmos.Business.Extensions.Holiday.Core.Helpers
{
    internal static class MonthHelper
    {
        public static bool DoesDayInMonth(int year, int month, int day)
        {
            return DateTime.DaysInMonth(year, month) >= day;
        }

        public static bool DoesDayInMonth(int year, int month, int day, out DateInfo dateInfo)
        {
            try
            {
                dateInfo = DateTime.DaysInMonth(year, month) >= day ? new DateInfo(year, month, day) : null;
                return dateInfo != null;
            }
            catch
            {
                dateInfo = null;
                return false;
            }
        }

        public static bool In(int fromMonth, int toMonth, int checkMonth)
        {
            var kuanian = fromMonth > toMonth;
            if (kuanian)
                return checkMonth >= fromMonth || checkMonth <= toMonth;

            return checkMonth >= toMonth && checkMonth <= fromMonth;
        }

        public static bool In(int fromMonth, int fromDay, int toMonth, int toDay, int checkMonth, int checkDay)
        {
            if (!In(fromMonth, toMonth, checkMonth))
                return false;

            if (checkMonth == fromMonth && checkDay < fromDay)
                return false;

            if (checkMonth == toMonth && checkDay > toDay)
                return false;

            return true;
        }
    }
}