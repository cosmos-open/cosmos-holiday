using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Lithuania.Religion
{
    /// <summary>
    /// St. John's Day
    /// </summary>
    public class StJohnsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Lithuania;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Lithuania;

        /// <inheritdoc />
        public override string Name { get; } = "Joninės, Rasos";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 6;

        /// <inheritdoc />
        public override int Day { get; set; } = 24;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_lt_john";
    }
}