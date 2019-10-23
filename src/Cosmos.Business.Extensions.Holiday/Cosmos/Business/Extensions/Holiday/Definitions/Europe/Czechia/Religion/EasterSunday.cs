using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Czechia.Religion
{
    /// <summary>
    /// Easter Monday<br />
    /// cz: Neděle velikonoční
    /// </summary>
    public class EasterSunday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Czechia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Czechia;

        /// <inheritdoc />
        public override string Name { get; } = "Neděle velikonoční";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cz_easter_sunday";
    }
}