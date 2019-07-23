using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Egypt.Public
{
    /// <summary>
    /// Armed Forces Day
    /// </summary>
    public class ArmedForcesDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Egypt;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Egypt;

        /// <inheritdoc />
        public override string Name { get; } = "عيد القوات المسلحة";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 6;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_eg_armed_forces";
    }
}