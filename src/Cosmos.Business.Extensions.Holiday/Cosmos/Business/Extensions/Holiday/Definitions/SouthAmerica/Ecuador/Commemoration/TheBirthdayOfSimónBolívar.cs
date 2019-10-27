using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Ecuador.Commemoration
{
    /// <summary>
    /// The Birthday of Simón Bolívar<br />
    /// es: El Natalicio de Simón Bolívar
    /// </summary>
    public class TheBirthdayOfSimónBolívar : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Ecuador;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Ecuador;

        /// <inheritdoc />
        public override string Name { get; } = "El Natalicio de Simón Bolívar";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 7;

        /// <inheritdoc />
        public override int Day { get; set; } = 24;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ec_birthday_of_simon_bolivar";
    }
}