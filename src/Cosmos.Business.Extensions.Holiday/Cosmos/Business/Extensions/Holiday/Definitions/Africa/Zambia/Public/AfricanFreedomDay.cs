using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Zambia.Public
{
    /// <summary>
    /// African Freedom Day
    /// </summary>
    public class AfricanFreedomDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Zambia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Zambia;

        /// <inheritdoc />
        public override string Name { get; } = "African Freedom Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 25;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_zm_freedom";
    }
}