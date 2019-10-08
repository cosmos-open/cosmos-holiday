using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.CongoBrazzaville.Religion
{
    /// <summary>
    /// Whit Monday<br />
    /// fr: Lundi de Pentecôte
    /// </summary>
    public class WhitSunday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.CongoBrazzaville;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.CongoBrazzaville;

        /// <inheritdoc />
        public override string Name { get; } = "Lundi de Pentecôte";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 7 * 7;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cg_whit_sunday";
    }
}