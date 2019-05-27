using System.Collections.Generic;
using Cosmos.I18N.Countries;
using EnumsNET;

namespace Cosmos.Business.Extensions.Weekends
{
    public static class WeekendManager
    {
        //https://en.wikipedia.org/wiki/Workweek_and_weekend
        private static readonly Dictionary<CountryCode, IWeekendDictionary> _nonUniversalWeekends;

        static WeekendManager()
        {
            _nonUniversalWeekends = new Dictionary<CountryCode, IWeekendDictionary>();
        }

        public static IWeekendDictionary GetWeekendDictionary(CountryCode code)
        {
            return _nonUniversalWeekends.TryGetValue(code, out var dictionary)
                ? dictionary
                : WeekendDictionary.Universal;
        }

        public static IWeekendDictionary GetWeekendDictionary(string weekendType)
        {
            var type = EnumsNET.Enums.GetMember<WeekendType>(weekendType, EnumFormat.EnumMemberValue, EnumFormat.Name, EnumFormat.DecimalValue);
            return (type?.Value ?? WeekendType.Universal).ToWeekendDictionary();
        }

        internal static void AddWeekendDictionary(CountryCode code, IWeekendDictionary weekendDictionary)
        {
            if (weekendDictionary == null)
                return;

            if (_nonUniversalWeekends.ContainsKey(code))
                return;

            if (weekendDictionary.Type == WeekendType.Universal)
                return;

            _nonUniversalWeekends.Add(code, weekendDictionary);
        }
    }
}