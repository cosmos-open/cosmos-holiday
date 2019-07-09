using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Austria.Commemoration
{
    /// <summary>
    /// St. Stephen's Day
    /// </summary>
    public class StStephensDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Austria;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Austria;

        /// <summary>
        /// Stefanitag
        /// </summary>
        public override string Name { get; } = "Stefanitag";

        /// <summary>
        /// Type of holiday
        /// </summary>
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 26;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_at_ststephensday";
    }
}