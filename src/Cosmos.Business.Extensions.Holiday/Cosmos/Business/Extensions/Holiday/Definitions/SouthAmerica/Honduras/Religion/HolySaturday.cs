using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Honduras.Religion
{
    /// <summary>
    /// Holy Saturday
    /// </summary>
    public class HolySaturday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Honduras;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Honduras;

        /// <inheritdoc />
        public override string Name { get; } = "Holy Saturday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_hn_holy_saturday";
    }
}