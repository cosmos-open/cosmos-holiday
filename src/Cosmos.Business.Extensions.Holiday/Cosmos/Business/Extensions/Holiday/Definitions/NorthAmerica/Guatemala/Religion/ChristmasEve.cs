using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Guatemala.Religion
{
    /// <summary>
    /// Christmas Eve
    /// </summary>
    public class ChristmasEve : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Guatemala;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Guatemala;

        /// <inheritdoc />
        public override string Name { get; } = "Christmas Eve";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 24;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gt_christmas_eve";
    }
}