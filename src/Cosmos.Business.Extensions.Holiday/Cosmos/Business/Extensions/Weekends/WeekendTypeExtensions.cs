namespace Cosmos.Business.Extensions.Weekends
{
    public static class WeekendTypeExtensions
    {
        public static IWeekendDictionary ToWeekendDictionary(this WeekendType weekendType)
        {
            switch (weekendType)
            {
                case WeekendType.Universal:
                    return WeekendDictionary.Universal;

                case WeekendType.SemiUniversal:
                    return WeekendDictionary.SemiUniversal;

                case WeekendType.FridaySunday:
                    return WeekendDictionary.FridaySunday;

                case WeekendType.FridayOnly:
                    return WeekendDictionary.FridayOnly;

                case WeekendType.SaturdayOnly:
                    return WeekendDictionary.SaturdayOnly;

                case WeekendType.SundayOnly:
                    return WeekendDictionary.SundayOnly;

                default:
                    return WeekendDictionary.Universal;
            }
        }
    }
}