using System;
using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday;
using Cosmos.Date;

namespace Cosmos.Business.Extensions.Weekends
{
    /// <summary>
    /// Interface for weekend
    /// </summary>
    public interface IWeekendDictionary
    {
        /// <summary>
        /// Type of weekend
        /// </summary>
        WeekendType Type { get; }
        
        /// <summary>
        /// WeekendDays
        /// </summary>
        IEnumerable<DayOfWeek> WeekendDays { get; }

        /// <summary>
        /// Is weekend
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        bool IsWeekend(DateTime date);

        /// <summary>
        /// Is weekend
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        bool IsWeekend(DateInfo date);

        /// <summary>
        /// Is weekend
        /// </summary>
        /// <param name="holiday"></param>
        /// <returns></returns>
        bool IsWeekend(HolidayInfo holiday);

        /// <summary>
        /// Is weekend
        /// </summary>
        /// <param name="weekendDay"></param>
        /// <returns></returns>
        bool IsWeekend(DayOfWeek weekendDay);

        /// <summary>
        /// Gets first weekend day
        /// </summary>
        DayOfWeek FirstWeekendDay { get; }

        /// <summary>
        /// Gets last weekend day
        /// </summary>
        DayOfWeek LastWeekendDay { get; }
    }
}