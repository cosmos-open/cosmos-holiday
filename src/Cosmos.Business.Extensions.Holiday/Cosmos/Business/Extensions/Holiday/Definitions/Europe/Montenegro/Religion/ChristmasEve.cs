using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Montenegro.Religion
{
    /// <summary>
    /// Christmas Eve<br />
    /// hr: Badnji dan
    /// </summary>
    public class ChristmasEve : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Montenegro;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Montenegro;

        /// <inheritdoc />
        public override string Name { get; } = "Badnji dan";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 24;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_me_christmas_eve";
    }
}