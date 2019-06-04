using System;
using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.Extensions.Holiday;
using Cosmos.Date;

namespace Cosmos.Business.Extensions.Weekends
{
    public class WeekendDictionary : IWeekendDictionary
    {
        public WeekendDictionary(WeekendType type, params DayOfWeek[] weekendDays)
        {
            Type = type;

            WeekendDays = weekendDays;

            var min = weekendDays.Min();
            var max = weekendDays.Max();

            if (max - min > min - max + 7)
            {
                FirstWeekendDay = min;
                LastWeekendDay = max;
            }
            else
            {
                FirstWeekendDay = max;
                LastWeekendDay = min;
            }
        }

        public WeekendType Type { get; }

        public IEnumerable<DayOfWeek> WeekendDays { get; }

        public bool IsWeekend(DateTime date) => IsWeekend(date.DayOfWeek);

        public bool IsWeekend(DateInfo date) => IsWeekend(date.ToDateTime().DayOfWeek);

        public bool IsWeekend(HolidayInfo holiday) => IsWeekend(holiday.ToDateTime().DayOfWeek);

        public bool IsWeekend(DayOfWeek weekendDay) => WeekendDays.Contains(weekendDay);

        public DayOfWeek FirstWeekendDay { get; }

        public DayOfWeek LastWeekendDay { get; }

        #region Static

        public static WeekendDictionary FridayOnly => new WeekendDictionary(WeekendType.FridayOnly, DayOfWeek.Friday);
        public static WeekendDictionary SaturdayOnly => new WeekendDictionary(WeekendType.SaturdayOnly, DayOfWeek.Saturday);
        public static WeekendDictionary SundayOnly => new WeekendDictionary(WeekendType.SundayOnly, DayOfWeek.Sunday);
        public static WeekendDictionary FridaySunday => new WeekendDictionary(WeekendType.FridaySunday, DayOfWeek.Friday, DayOfWeek.Sunday);
        public static WeekendDictionary SemiUniversal => new WeekendDictionary(WeekendType.SemiUniversal, DayOfWeek.Friday, DayOfWeek.Saturday);
        public static WeekendDictionary Universal => new WeekendDictionary(WeekendType.Universal, DayOfWeek.Saturday, DayOfWeek.Sunday);


        #endregion
    }
}