using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Italy.Religion
{
    /// <summary>
    /// Easter Sunday
    /// </summary>
    public class EasterSunday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Italy;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Italy;

        /// <inheritdoc />
        public override string Name { get; } = "Pasqua";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_it_easter_sunday";
    }
}