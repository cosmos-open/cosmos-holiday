using Cosmos.Abstractions;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Weekends.SpecialDefinitions
{
    /// <summary>
    /// HongKong
    /// </summary>
    [WeekendDefinitionIgnoreScanning]
    public class HongKong : IBizWeekendDefinition, IBizHolidayDefinition, IBizRegionHolidayDefinition
    {
        /// <summary>
        /// Country or region
        /// </summary>
        public Country Country { get; } = Country.HongKong;

        /// <summary>
        /// Belong to country
        /// </summary>
        public Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// Type of weekend
        /// </summary>
        //https://en.wikipedia.org/wiki/Workweek_and_weekend
        public WeekendType WeekendType { get; } = WeekendType.SundayOnly;
    }
}