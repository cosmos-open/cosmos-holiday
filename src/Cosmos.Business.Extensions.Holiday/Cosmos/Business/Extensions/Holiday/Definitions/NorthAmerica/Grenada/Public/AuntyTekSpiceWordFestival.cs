using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Grenada.Public
{
    /// <summary>
    /// Aunty Tek Spice Word Festival
    /// </summary>
    public class AuntyTekSpiceWordFestival : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Grenada;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Grenada;

        /// <inheritdoc />
        public override string Name { get; } = "Aunty Tek Spice Word Festival";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 15;

        /// <inheritdoc />
        public override int Length { get; } = 5;
        
        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gd_aunty_tek_spice_word";
    }
}