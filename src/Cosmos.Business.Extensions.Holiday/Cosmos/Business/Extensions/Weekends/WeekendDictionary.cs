using System;
using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.Extensions.Holiday;
using Cosmos.Date;

namespace Cosmos.Business.Extensions.Weekends
{
    /// <summary>
    /// Weekend dictionary
    /// </summary>
    public class WeekendDictionary : IWeekendDictionary
    {
        /// <summary>
        /// Create a new instance of <see cref="WeekendDictionary"/>
        /// </summary>
        /// <param name="type"></param>
        /// <param name="weekendDays"></param>
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

        /// <summary>
        /// Type of weekend
        /// </summary>
        public WeekendType Type { get; }

        /// <summary>
        /// Weekend days
        /// </summary>
        public IEnumerable<DayOfWeek> WeekendDays { get; }

        /// <summary>
        /// Is weekend
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public bool IsWeekend(DateTime date) => IsWeekend(date.DayOfWeek);

        /// <summary>
        /// Is weekend
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public bool IsWeekend(DateInfo date) => IsWeekend(date.ToDateTime().DayOfWeek);

        /// <summary>
        /// Is weekend
        /// </summary>
        /// <param name="holiday"></param>
        /// <returns></returns>
        public bool IsWeekend(HolidayInfo holiday) => IsWeekend(holiday.ToDateTime().DayOfWeek);

        /// <summary>
        /// Is weekend
        /// </summary>
        /// <param name="weekendDay"></param>
        /// <returns></returns>
        public bool IsWeekend(DayOfWeek weekendDay) => WeekendDays.Contains(weekendDay);

        /// <summary>
        /// Gets first weekend day
        /// </summary>
        public DayOfWeek FirstWeekendDay { get; }

        /// <summary>
        /// Gets last weekend day
        /// </summary>
        public DayOfWeek LastWeekendDay { get; }

        #region Static

        /// <summary>
        /// Friday only
        /// </summary>
        public static WeekendDictionary FridayOnly => new WeekendDictionary(WeekendType.FridayOnly, DayOfWeek.Friday);

        /// <summary>
        /// Saturday only
        /// </summary>
        public static WeekendDictionary SaturdayOnly => new WeekendDictionary(WeekendType.SaturdayOnly, DayOfWeek.Saturday);

        /// <summary>
        /// Sunday only
        /// </summary>
        public static WeekendDictionary SundayOnly => new WeekendDictionary(WeekendType.SundayOnly, DayOfWeek.Sunday);

        /// <summary>
        /// Friday funday
        /// </summary>
        public static WeekendDictionary FridaySunday => new WeekendDictionary(WeekendType.FridaySunday, DayOfWeek.Friday, DayOfWeek.Sunday);

        /// <summary>
        /// Semi universal
        /// </summary>
        public static WeekendDictionary SemiUniversal => new WeekendDictionary(WeekendType.SemiUniversal, DayOfWeek.Friday, DayOfWeek.Saturday);

        /// <summary>
        /// Universal
        /// </summary>
        public static WeekendDictionary Universal => new WeekendDictionary(WeekendType.Universal, DayOfWeek.Saturday, DayOfWeek.Sunday);

        #endregion

    }
}