using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Iceland.Religion
{
    /// <summary>
    /// Whit Sunday
    /// </summary>
    public class WhitSunday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Iceland;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Iceland;

        /// <inheritdoc />
        public override string Name { get; } = "Hvítasunnudagur";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 7 * 7;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_is_whit_sunday";
    }
}