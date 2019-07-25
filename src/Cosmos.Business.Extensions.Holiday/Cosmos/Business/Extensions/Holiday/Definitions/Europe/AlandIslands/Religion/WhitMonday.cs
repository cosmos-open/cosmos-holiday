using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.AlandIslands.Religion
{
    /// <summary>
    /// WhitMonday
    /// </summary>
    public class WhitMonday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.AlandIslands;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Finland;

        /// <inheritdoc />
        public override string Name { get; } = "Annandag Pingst";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 1 + 7 * 7;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ax_whit_monday";
    }
}