using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Haiti.Religion
{
    /// <summary>
    /// Easter Sunday
    /// </summary>
    public class EasterSunday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Haiti;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Haiti;

        /// <inheritdoc />
        public override string Name { get; } = "Pâques";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ht_easter_sunday";
    }
}