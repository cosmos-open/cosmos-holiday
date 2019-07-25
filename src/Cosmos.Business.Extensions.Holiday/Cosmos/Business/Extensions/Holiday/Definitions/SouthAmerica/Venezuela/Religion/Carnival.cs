using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Venezuela.Religion
{
    /// <summary>
    /// Carnival
    /// </summary>
    public class Carnival : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Venezuela;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Venezuela;

        /// <inheritdoc />
        public override string Name { get; } = "Carnaval";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -47;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ve_carnival";
    }
}