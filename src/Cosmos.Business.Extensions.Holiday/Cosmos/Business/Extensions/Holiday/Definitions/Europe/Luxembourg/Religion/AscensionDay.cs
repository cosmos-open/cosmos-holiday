using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Luxembourg.Religion
{
    /// <summary>
    /// Ascension Day
    /// </summary>
    public class AscensionDay : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Luxembourg;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Luxembourg;

        /// <inheritdoc />
        public override string Name { get; } = "Christi Himmelfaart";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 4 + 5 * 7;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_lu_ascension_day";
    }
}