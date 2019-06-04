using Cosmos.Abstractions;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Weekends.SpecialDefinitions
{
    [WeekendDefinitionIgnoreScanning]
    public class HongKong : IBizWeekendDefinition, IBizHolidayDefinition, IBizRegionHolidayDefinition
    {
        public Country Country { get; } = Country.HongKong;
        public Country BelongsToCountry { get; } = Country.China;
        
        //https://en.wikipedia.org/wiki/Workweek_and_weekend
        public WeekendType WeekendType { get; } = WeekendType.SundayOnly;
    }
}