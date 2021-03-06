using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.BurkinaFaso.Religion
{
    /// <summary>
    /// Pentecost<br />
    /// fr: Pentecôte
    /// en: Pentecost
    /// </summary>
    public class Pentecost : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.BurkinaFaso;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.BurkinaFaso;

        /// <inheritdoc />
        public override string Name { get; } = "Pentecôte";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 7 * 7;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bf_pentecost";
    }
}