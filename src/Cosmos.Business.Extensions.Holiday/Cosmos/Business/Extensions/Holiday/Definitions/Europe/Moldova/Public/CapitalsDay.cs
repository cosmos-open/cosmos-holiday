using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Moldova.Public
{
    /// <summary>
    /// Capital's Day
    /// </summary>
    public class CapitalsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Moldova;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Moldova;

        /// <inheritdoc />
        public override string Name { get; } = "Capital's Day";

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 14;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_md_capitals";
    }
}