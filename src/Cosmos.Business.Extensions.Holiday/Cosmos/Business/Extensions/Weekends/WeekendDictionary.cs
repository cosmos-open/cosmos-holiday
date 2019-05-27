using System;
using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.Extensions.Holiday;
using Cosmos.Date;

namespace Cosmos.Business.Extensions.Weekends
{
    public partial class WeekendDictionary : IWeekendDictionary
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

        public WeekendType Type { get; } = WeekendType.Universal;

        public IEnumerable<DayOfWeek> WeekendDays { get; }

        public bool IsWeekend(DateTime date) => IsWeekend(date.DayOfWeek);

        public bool IsWeekend(DateInfo date) => IsWeekend(date.ToDateTime().DayOfWeek);

        public bool IsWeekend(HolidayInfo holiday) => IsWeekend(holiday.ToDateTime().DayOfWeek);

        public bool IsWeekend(DayOfWeek weekendDay) => WeekendDays.Contains(weekendDay);

        public DayOfWeek FirstWeekendDay { get; }

        public DayOfWeek LastWeekendDay { get; }
    }
}