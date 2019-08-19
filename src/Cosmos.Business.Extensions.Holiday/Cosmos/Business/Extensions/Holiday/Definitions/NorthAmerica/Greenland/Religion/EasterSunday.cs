using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Greenland.Religion
{
    /// <summary>
    /// Easter Monday
    /// </summary>
    public class EasterSunday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Greenland;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Greenland;

        /// <inheritdoc />
        public override string Name { get; } = "Easter Sunday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gl_easter_sunday";
    }
}