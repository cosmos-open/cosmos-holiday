using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Uruguay.Religion
{
    /// <summary>
    /// Carnival
    /// </summary>
    public class Carnival48 : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Uruguay;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Uruguay;

        /// <inheritdoc />
        public override string Name { get; } = "Carnaval";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -48;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_uy_carnival48";
    }
}