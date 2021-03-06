using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Greenland.Religion
{
    /// <summary>
    /// Christi Himmelfahrt
    /// </summary>
    public class WhitMonday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Greenland;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Greenland;

        /// <inheritdoc />
        public override string Name { get; } = "Δευτέρα Πεντηκοστής";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 1 + 7 * 7;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gl_whit_monday";
    }
}