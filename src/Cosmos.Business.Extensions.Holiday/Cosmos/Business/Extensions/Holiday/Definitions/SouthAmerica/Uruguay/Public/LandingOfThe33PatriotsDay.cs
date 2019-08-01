using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Uruguay.Public
{
    /// <summary>
    /// Landing of the 33 Patriots Day
    /// </summary>
    public class LandingOfThe33PatriotsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Uruguay;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Uruguay;

        /// <inheritdoc />
        public override string Name { get; } = "Desembarco de los 33 Orientales";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 4;

        /// <inheritdoc />
        public override int Day { get; set; } = 19;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_uy_landing_33_patriots";
    }
}