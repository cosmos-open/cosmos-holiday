using Cosmos.Abstractions;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Weekends.SpecialDefinitions
{
    /// <summary>
    /// Yemen
    /// </summary>
    [WeekendDefinitionIgnoreScanning]
    public class Yemen : IBizWeekendDefinition, IBizHolidayDefinition
    {
        /// <summary>
        /// Country
        /// </summary>
        public Country Country { get; } = Country.Yemen;
        
        /// <summary>
        /// Type of weekend
        /// </summary>
        //https://en.wikipedia.org/wiki/Workweek_and_weekend
        public WeekendType WeekendType { get; } = WeekendType.SemiUniversal;
    }
}