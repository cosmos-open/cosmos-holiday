using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Uruguay.Religion
{
    /// <summary>
    /// Good Friday
    /// </summary>
    public class GoodFriday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Uruguay;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Uruguay;
        
        /// <inheritdoc />
        public override string Name { get; } = "Semana de Turismo";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_uy_good_friday";
    }
}