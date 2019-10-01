using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.CentralAfrican.Religion
{
    /// <summary>
    /// Easter Monday<br />
    /// fr: Lundi de Pâques
    /// </summary>
    public class EasterMonday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.CentralAfrican;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.CentralAfrican;

        /// <inheritdoc />
        public override string Name { get; } = "Lundi de Pâques";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cf_easter_monday";
    }
}