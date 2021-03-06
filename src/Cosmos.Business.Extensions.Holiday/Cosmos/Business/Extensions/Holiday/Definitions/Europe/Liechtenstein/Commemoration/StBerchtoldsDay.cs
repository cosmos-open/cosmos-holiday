using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Liechtenstein.Commemoration
{
    /// <summary>
    /// St. Berchtold's Day
    /// </summary>
    public class StBerchtoldsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Liechtenstein;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Liechtenstein;

        /// <inheritdoc />
        public override string Name { get; } = "Berchtoldstag";

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 2;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_li_berchtold";

        /// <inheritdoc />
        public override int? Since { get; set; } = 1967;
    }
}