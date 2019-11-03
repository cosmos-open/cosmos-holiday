using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Tanzania.Public
{
    /// <summary>
    /// Zanzibar Revolution Day
    /// </summary>
    public class ZanzibarRevolutionDay: BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Tanzania;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Tanzania;

        /// <inheritdoc />
        public override string Name { get; } = "Zanzibar Revolution Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_tz_revolution";
    }
}