using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Chile.Public
{
    /// <summary>
    /// Navy Day
    /// </summary>
    public class NavyDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Chile;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Chile;

        /// <inheritdoc />
        public override string Name { get; } = "Día de las Glorias Navales";

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 21;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cl_navy";
    }
}