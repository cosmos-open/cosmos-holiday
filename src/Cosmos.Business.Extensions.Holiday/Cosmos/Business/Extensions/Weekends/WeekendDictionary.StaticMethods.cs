using System;

namespace Cosmos.Business.Extensions.Weekends
{
    public partial class WeekendDictionary
    {
        public static WeekendDictionary FridayOnly => new WeekendDictionary(WeekendType.FridayOnly, DayOfWeek.Friday);
        public static WeekendDictionary SaturdayOnly => new WeekendDictionary(WeekendType.SaturdayOnly, DayOfWeek.Saturday);
        public static WeekendDictionary SundayOnly => new WeekendDictionary(WeekendType.SundayOnly, DayOfWeek.Sunday);
        public static WeekendDictionary FridaySunday => new WeekendDictionary(WeekendType.FridaySunday, DayOfWeek.Friday, DayOfWeek.Sunday);
        public static WeekendDictionary SemiUniversal => new WeekendDictionary(WeekendType.SemiUniversal, DayOfWeek.Friday, DayOfWeek.Saturday);
        public static WeekendDictionary Universal => new WeekendDictionary(WeekendType.Universal, DayOfWeek.Saturday, DayOfWeek.Sunday);
    }
}