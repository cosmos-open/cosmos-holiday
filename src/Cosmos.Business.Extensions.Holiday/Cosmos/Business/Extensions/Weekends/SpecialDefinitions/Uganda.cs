using Cosmos.Abstractions;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Weekends.SpecialDefinitions
{
    /// <summary>
    /// Uganda
    /// </summary>
    [WeekendDefinitionIgnoreScanning]
    public class Uganda : IBizWeekendDefinition, IBizHolidayDefinition
    {
        /// <summary>
        /// Country
        /// </summary>
        public Country Country { get; } = Country.Uganda;

        /// <summary>
        /// Type of weekend
        /// </summary>
        //https://en.wikipedia.org/wiki/Workweek_and_weekend
        public WeekendType WeekendType { get; } = WeekendType.SundayOnly;
    }
}