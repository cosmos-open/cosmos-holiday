using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Cyprus.Religion
{
    /// <summary>
    /// Clean Monday
    /// </summary>
    public class CleanMonday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Cyprus;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Cyprus;

        /// <inheritdoc />
        public override string Name { get; } = "Clean Monday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -48;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cy_clean_monday";
    }
}