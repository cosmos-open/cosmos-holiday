using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Gambia.Religion
{
    /// <summary>
    /// Christmas Day
    /// </summary>
    public class ChristmasDay: BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Gambia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Gambia;

        /// <inheritdoc />
        public override string Name { get; } = "Christmas Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 25;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gm_christmas";
    }
}