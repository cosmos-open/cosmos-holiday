using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Montenegro.Religion
{
    /// <summary>
    /// Easter Sunday<br />
    /// hr: Uskrs
    /// </summary>
    public class EasterSunday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Montenegro;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Montenegro;

        /// <inheritdoc />
        public override string Name { get; } = "Uskrs";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_me_easter_sunday";
    }
}