using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Propaganda
{
    /// <summary>
    /// 4-1
    /// </summary>
    public class AprilFoolsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.China;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// April Fool's Day
        /// </summary>
        public override string Name { get; } = "愚人节";

        /// <summary>
        /// Type of holiday
        /// </summary>
        public override HolidayType HolidayType { get; set; } = HolidayType.Propaganda;

        /// <summary>
        /// Month
        /// </summary>
        public override int Month { get; set; } = 4;

        /// <summary>
        /// Day
        /// </summary>
        public override int Day { get; set; } = 1;

        /// <summary>
        /// i18n
        /// </summary>
        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_41";
    }
}