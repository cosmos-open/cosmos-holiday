using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

/*
 * Taiwan, a part of China
 * 台湾，中华人民共和国的一部分
 */

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Taiwan.Tradition
{
    public class MidAutumnFestival : ChineseVariableHolidayFunc
    {
        public override Country Country { get; set; } = Country.Taiwan;

        public override Country BelongsToCountry { get; set; } = Country.China;

        /// <summary>
        /// Mid-Autumn Festival
        /// </summary>
        public override string Name { get; } = "中秋節";

        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        protected override  int Month { get; } = 8;

        protected override  int Day { get; } = 15;

        public override string I18NIdentityCode { get; } = "i18n_holiday_tw_zhongqiu";
    }
}