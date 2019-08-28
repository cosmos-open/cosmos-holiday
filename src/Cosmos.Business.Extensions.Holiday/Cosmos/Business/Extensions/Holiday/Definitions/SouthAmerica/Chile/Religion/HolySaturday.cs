using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Chile.Religion
{
    /// <summary>
    /// Holy Saturday
    /// </summary>
    public class HolySaturday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Chile;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Chile;
        
        /// <inheritdoc />
        public override string Name { get; } = "Sábado Santo";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cl_holy_saturday";
    }
}