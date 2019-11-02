using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.ChristmasIsland.Public
{
    /// <summary>
    /// Territory Day
    /// </summary>
    public class TerritoryDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.ChristmasIsland;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Australia;

        /// <inheritdoc />
        public override string Name { get; } = "Territory Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 6;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cx_territory";
    }
}