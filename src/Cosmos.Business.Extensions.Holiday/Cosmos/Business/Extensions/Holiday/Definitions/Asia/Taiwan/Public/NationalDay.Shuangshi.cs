using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

/*
 * Taiwan, a part of China
 * 台湾，中华人民共和国的一部分
 */

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Taiwan.Public
{
    /// <summary>
    /// 中秋节
    /// </summary>
    public class MinGuoNationalDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Taiwan;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// National Day
        /// </summary>
        public override string Name { get; } = "民國國慶";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 10;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_tw_guoqing_mg";

        /*
         * 中华民国（1912-1949），位于亚洲东部、东临太平洋。是辛亥革命以后建立的亚洲第一个民主共和国，简称民国。
         */

        /// <inheritdoc />
        public override int? Since { get; } = 1912;

        /// <inheritdoc />
        public override int? End { get; } = 1948;
    }
}