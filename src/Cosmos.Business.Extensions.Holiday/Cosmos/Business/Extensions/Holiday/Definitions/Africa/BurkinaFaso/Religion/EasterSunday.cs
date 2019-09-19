using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.BurkinaFaso.Religion
{
    /// <summary>
    /// Easter Monday<br />
    /// fr: Pâques
    /// </summary>
    public class EasterSunday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.BurkinaFaso;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.BurkinaFaso;

        /// <inheritdoc />
        public override string Name { get; } = "Pâques";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bf_easter_sunday";
    }
}