using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Propaganda
{
    /// <summary>
    /// 助残日
    /// </summary>
    public class ZhuCan : WeekOffsetVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.China;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.China;

        /// <inheritdoc />
        public override string Name { get; } = "全国助残日";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Propaganda;

        /// <inheritdoc />
        public override int Month { get; } = 5;

        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 3;

        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Sunday;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_zhucan";

        /*
         * 中国全国助残日是中国残疾人节日。
         *
         * 1990年12月28日第七届全国人民代表大会常务委员会第十七次会议审议通过的
         * 《中华人民共和国残疾人保障法》第14条规定：“每年五月第三个星期日，为全国助残日。”
         *
         * 《中华人民共和国残疾人保障法》从1991年5月15日开始实施，“全国助残日”活动即从1991年开始进行。
         * 全国每年都进行“助残日”活动。
         */

        /// <inheritdoc />
        public override int? Since { get; } = 1991;
    }
}