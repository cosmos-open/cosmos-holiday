using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Jamaica.Religion
{
    /// <summary>
    /// Ash Wednesday
    /// </summary>
    public class AshWednesday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Jamaica;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Jamaica;

        /// <inheritdoc />
        public override string Name { get; } = "Ash Wednesday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -46;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_jm_ash_wednesday";
    }
}