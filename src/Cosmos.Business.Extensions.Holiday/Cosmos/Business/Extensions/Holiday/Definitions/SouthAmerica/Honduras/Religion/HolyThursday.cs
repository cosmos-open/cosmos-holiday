using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Honduras.Religion
{
    /// <summary>
    /// Holy Thursday
    /// </summary>
    public class HolyThursday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Honduras;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Honduras;

        /// <inheritdoc />
        public override string Name { get; } = "Holy Thursday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -3;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_hn_holy_thursday";
    }
}