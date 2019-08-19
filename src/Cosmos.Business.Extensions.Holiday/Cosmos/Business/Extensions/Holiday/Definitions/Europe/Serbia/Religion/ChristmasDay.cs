using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Serbia.Religion
{
    /// <summary>
    /// Christmas Day
    /// </summary>
    public class ChristmasDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Serbia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Serbia;

        /// <inheritdoc />
        public override string Name { get; } = "Božić";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 7;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_rs_christmas";
    }
}