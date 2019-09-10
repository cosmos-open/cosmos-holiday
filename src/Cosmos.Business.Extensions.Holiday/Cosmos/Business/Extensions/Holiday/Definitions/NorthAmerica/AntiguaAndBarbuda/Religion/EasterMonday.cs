using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.AntiguaAndBarbuda.Religion
{
    /// <summary>
    /// Easter Monday
    /// </summary>
    public class EasterMonday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.AntiguaAndBarbuda;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.AntiguaAndBarbuda;

        /// <inheritdoc />
        public override string Name { get; } = "Easter Monday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ag_easter_monday";
    }
}