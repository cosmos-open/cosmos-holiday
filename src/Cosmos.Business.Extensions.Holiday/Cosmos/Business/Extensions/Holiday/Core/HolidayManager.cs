using Cosmos.Business.Extensions.Weekends;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    internal static class HolidayManager
    {
        public static IWeekendDictionary GetWeekendDictionary(CountryCode code) => WeekendManager.GetWeekendDictionary(code);

        public static IWeekendDictionary GetWeekendDictionary(string type) => WeekendManager.GetWeekendDictionary(type);
    }
}