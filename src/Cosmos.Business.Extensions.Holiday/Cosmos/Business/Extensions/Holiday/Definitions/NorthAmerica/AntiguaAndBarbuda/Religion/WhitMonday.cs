using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.AntiguaAndBarbuda.Religion
{
    /// <summary>
    /// Christi Himmelfahrt
    /// </summary>
    public class WhitMonday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.AntiguaAndBarbuda;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.AntiguaAndBarbuda;

        /// <inheritdoc />
        public override string Name { get; } = "Whit Monday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 1 + 7 * 7;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ag_whit_monday";
    }
}