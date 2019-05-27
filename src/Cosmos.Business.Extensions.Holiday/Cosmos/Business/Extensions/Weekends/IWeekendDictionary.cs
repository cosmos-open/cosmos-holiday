using System;
using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday;
using Cosmos.Date;

namespace Cosmos.Business.Extensions.Weekends
{
    public interface IWeekendDictionary
    {
        WeekendType Type { get; }
        
        IEnumerable<DayOfWeek> WeekendDays { get; }

        bool IsWeekend(DateTime date);

        bool IsWeekend(DateInfo date);

        bool IsWeekend(HolidayInfo holiday);

        bool IsWeekend(DayOfWeek weekendDay);

        DayOfWeek FirstWeekendDay { get; }

        DayOfWeek LastWeekendDay { get; }
    }
}