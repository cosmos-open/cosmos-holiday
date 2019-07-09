using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Austria.Religion
{
    /// <summary>
    /// Christi Himmelfahrt
    /// </summary>
    public class AscensionDay : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Austria;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Austria;

        /// <inheritdoc />
        public override string Name { get; } = "Christi Himmelfahrt";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 4 + 5 * 7;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_at_ascension_day";
    }
}