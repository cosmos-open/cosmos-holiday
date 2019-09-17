using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.BosniaAndHerzegovina.Religion
{
    /// <summary>
    /// Easter Sunday<br />
    /// bs: Vaskrs
    /// sr: Католички Васкрс
    /// hr: Uskrs
    /// </summary>
    public class EasterSunday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.BosniaAndHerzegovina;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.BosniaAndHerzegovina;

        /// <inheritdoc />
        public override string Name { get; } = "Vaskrs";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ba_easter_sunday";
    }
}