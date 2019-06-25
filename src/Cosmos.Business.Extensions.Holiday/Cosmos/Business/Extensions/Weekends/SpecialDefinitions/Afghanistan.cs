using Cosmos.Abstractions;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Weekends.SpecialDefinitions
{
    /// <summary>
    /// Afghanistan weekend provider
    /// </summary>
    [WeekendDefinitionIgnoreScanning]
    public class Afghanistan : IBizWeekendDefinition, IBizHolidayDefinition
    {
        /// <summary>
        /// Countrry or region
        /// </summary>
        public Country Country { get; } = Country.Afghanistan;
        
        /// <summary>
        /// Type of weekend
        /// </summary>
        //https://en.wikipedia.org/wiki/Workweek_and_weekend
        public WeekendType WeekendType { get; } = WeekendType.SemiUniversal;
    }
}