using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Egypt.Religion
{
    /// <summary>
    /// Christmas
    /// </summary>
    public class Christmas : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Egypt;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Egypt;

        /// <summary>
        /// April Fool's Day
        /// </summary>
        public override string Name { get; } = "عيد الميلاد المجيد";

        /// <summary>
        /// Type of holiday
        /// </summary>
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <summary>
        /// Month
        /// </summary>
        public override int Month { get; set; } = 1;

        /// <summary>
        /// Day
        /// </summary>
        public override int Day { get; set; } = 7;

        /// <summary>
        /// i18n
        /// </summary>
        public override string I18NIdentityCode { get; } = "i18n_holiday_eg_christmas";
    }
}