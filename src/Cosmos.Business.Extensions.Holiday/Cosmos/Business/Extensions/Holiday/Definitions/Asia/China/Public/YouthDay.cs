using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Public
{
    /// <summary>
    /// 五四青年节
    /// </summary>
    public class YouthDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.China;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// Youth Day
        /// </summary>
        public override string Name { get; } = "五四青年节";

        /// <summary>
        /// Type of holiday
        /// </summary>
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 4;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_54";

        /*
         * 五四青年节源于中国1919年反帝爱国的“五四运动”，
         * 五四爱国运动是一次彻底的反对帝国主义和封建主义的爱国运动，
         * 也是中国新民主主义革命的开始。         *
         * 1939年，陕甘宁边区西北青年救国联合会规定5月4日为中国青年节。
         *
         * 青年节期间，中国各地都要举行丰富多彩的纪念活动，
         * 青年们还要集中进行各种社会志愿和社会实践活动，
         * 还有许多地方在青年节期间举行成人仪式。
         */

        /// <inheritdoc />
        public override int? Since { get; } = 1939;
    }
}