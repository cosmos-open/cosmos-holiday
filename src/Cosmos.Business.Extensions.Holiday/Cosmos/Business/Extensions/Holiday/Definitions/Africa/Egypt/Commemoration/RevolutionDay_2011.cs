using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Egypt.Commemoration
{
    /// <summary>
    /// Revolution Day 2011 National Police Day
    /// </summary>
    public class RevolutionDay2011 : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Egypt;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Egypt;

        /// <summary>
        /// April Fool's Day
        /// </summary>
        public override string Name { get; } = "عيد الثورة 25 يناير";

        /// <summary>
        /// Type of holiday
        /// </summary>
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <summary>
        /// Month
        /// </summary>
        public override int Month { get; set; } = 1;

        /// <summary>
        /// Day
        /// </summary>
        public override int Day { get; set; } = 25;

        /// <summary>
        /// i18n
        /// </summary>
        public override string I18NIdentityCode { get; } = "i18n_holiday_eg_revolution_day_2011";

        /// <inheritdoc />
        public override int? Since { get; } = 2011;
    }
}