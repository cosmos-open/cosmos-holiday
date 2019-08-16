using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Poland.Religion
{
    /// <summary>
    /// Easter Day
    /// </summary>
    public class EasterDay : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Poland;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Poland;

        /// <inheritdoc />
        public override string Name { get; } = "Wielkanoc";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_pl_easter_day";
    }
}