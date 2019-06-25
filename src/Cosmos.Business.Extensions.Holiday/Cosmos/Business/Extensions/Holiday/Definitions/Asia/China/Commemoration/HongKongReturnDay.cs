using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Commemoration
{
    /// <summary>
    /// HongKong's return day
    /// </summary>
    public class HongKongReturnDay : BaseFixedHolidayFunc
    {
        /// <summary>
        /// Country
        /// </summary>
        public override Country Country { get; } = Country.China;

        /// <summary>
        /// belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// Hongkong's return day
        /// </summary>
        public override string Name { get; } = "香港回归纪念日";

        /// <summary>
        /// Type of holiday
        /// </summary>
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <summary>
        /// Month
        /// </summary>
        public override int Month { get; set; } = 7;

        /// <summary>
        /// Day
        /// </summary>
        public override int Day { get; set; } = 1;

        /// <summary>
        /// i18n
        /// </summary>
        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_hk1997";

        /// <summary>
        /// Since...
        /// </summary>
        public override int? Since { get; } = 1997;

    }
}