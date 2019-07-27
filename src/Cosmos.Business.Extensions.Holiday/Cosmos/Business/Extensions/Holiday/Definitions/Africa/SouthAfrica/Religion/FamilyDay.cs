using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.SouthAfrica.Religion
{
    /// <summary>
    /// Family Day
    /// </summary>
    public class FamilyDay : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.SouthAfrica;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.SouthAfrica;

        /// <inheritdoc />
        public override string Name { get; } = "Family Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_za_family_day";

        /// <inheritdoc />
        public override int? Since { get; } = 1910;
    }
}