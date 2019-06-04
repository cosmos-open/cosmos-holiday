using Cosmos.Abstractions;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Weekends.SpecialDefinitions
{
    [WeekendDefinitionIgnoreScanning]
    public class Somalia : IBizWeekendDefinition, IBizHolidayDefinition
    {
        public Country Country { get; } = Country.Somalia;
        
        //https://en.wikipedia.org/wiki/Workweek_and_weekend
        public WeekendType WeekendType { get; } = WeekendType.FridayOnly;
    }
}