using Cosmos.Abstractions;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Weekends.SpecialDefinitions
{
    [WeekendDefinitionIgnoreScanning]
    public class Oman : IBizWeekendDefinition, IBizHolidayDefinition
    {
        public Country Country { get; } = Country.Oman;
        
        //https://en.wikipedia.org/wiki/Workweek_and_weekend
        public WeekendType WeekendType { get; } = WeekendType.SemiUniversal;
    }
}