using Cosmos.Abstractions;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Weekends.SpecialDefinitions
{
    [WeekendDefinitionIgnoreScanning]
    public class Nepal : IBizWeekendDefinition, IBizHolidayDefinition
    {
        public Country Country { get; } = Country.Nepal;
        
        //https://en.wikipedia.org/wiki/Workweek_and_weekend
        public WeekendType WeekendType { get; } = WeekendType.SaturdayOnly;
    }
}