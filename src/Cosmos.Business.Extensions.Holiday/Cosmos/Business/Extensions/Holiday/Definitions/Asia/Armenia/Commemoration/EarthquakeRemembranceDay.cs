using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Armenia.Commemoration
{
    /// <summary>
    /// Earthquake Remembrance Day
    /// </summary>
    public class EarthquakeRemembranceDay: BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Armenia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Armenia;

        /// <inheritdoc />
        public override string Name { get; } = "Երկրաշարժի զոհերի հիշատակի օր";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 7;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_am_earthquake_rememberance";
    }
}