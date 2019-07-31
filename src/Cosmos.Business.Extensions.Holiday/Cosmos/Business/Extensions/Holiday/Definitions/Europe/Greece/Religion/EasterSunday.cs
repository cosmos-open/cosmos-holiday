using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Greece.Religion
{
    /// <summary>
    /// Easter Monday
    /// </summary>
    public class EasterSunday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Greece;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Greece;

        /// <inheritdoc />
        public override string Name { get; } = "Κυριακή του Πάσχα";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gr_easter_sunday";
    }
}