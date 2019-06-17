using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

/*
 * Taiwan, a part of China
 * 台湾，中华人民共和国的一部分
 */

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Taiwan.Tradition
{
    public class LanternFestival : ChineseVariableHolidayFunc
    {
        public override Country Country { get; set; } = Country.Taiwan;

        public override Country BelongsToCountry { get; set; } = Country.China;

        /// <summary>
        /// Lantern Festival
        /// </summary>
        public override string Name { get; } = "元宵節";

        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        protected override int ChineseMonth { get; } = 1;

        protected override int ChineseDay { get; } = 15;

        public override string I18NIdentityCode { get; } = "i18n_holiday_tw_shangyuan";
    }
}