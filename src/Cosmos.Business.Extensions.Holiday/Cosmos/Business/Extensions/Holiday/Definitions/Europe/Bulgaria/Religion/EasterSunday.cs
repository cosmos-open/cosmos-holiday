using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Bulgaria.Religion
{
    /// <summary>
    /// Easter Sunday
    /// </summary>
    public class EasterSunday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bulgaria;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Bulgaria;

        /// <inheritdoc />
        public override string Name { get; } = "Великден";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bg_easter_sunday";
    }
}