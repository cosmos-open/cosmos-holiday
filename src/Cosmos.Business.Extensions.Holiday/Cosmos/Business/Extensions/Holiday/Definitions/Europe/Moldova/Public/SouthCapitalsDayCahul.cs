using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Moldova.Public
{
    /// <summary>
    /// South Capital's Day Cahul
    /// </summary>
    public class SouthCapitalsDayCahul : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Moldova;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Moldova;

        /// <inheritdoc />
        public override string Name { get; } = "South Capital's Day - Cahul";

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 21;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_md_capitals_south";
    }
}