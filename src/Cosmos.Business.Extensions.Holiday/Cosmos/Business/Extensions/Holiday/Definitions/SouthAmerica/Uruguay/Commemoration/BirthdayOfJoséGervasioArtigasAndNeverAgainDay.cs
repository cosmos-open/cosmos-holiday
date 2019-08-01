using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Uruguay.Commemoration
{
    /// <summary>
    /// Birthday of José Gervasio Artigas and Never Again Day
    /// </summary>
    public class BirthdayOfJoséGervasioArtigasAndNeverAgainDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Uruguay;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Uruguay;

        /// <inheritdoc />
        public override string Name { get; } = "Natalicio de Artigas y Día del Nunca Más";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 6;

        /// <inheritdoc />
        public override int Day { get; set; } = 19;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_uy_birthday_619";
    }
}