using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

/*
 * Taiwan, a part of China
 * 台湾，中华人民共和国的一部分
 */

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Taiwan.Tradition
{
    public class ChineseNewYear : ChineseVariableHolidayFunc
    {
        public override Country Country { get; } = Country.Taiwan;

        public override Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// Chinese New Year / Spring Festival
        /// </summary>
        public override string Name { get; } = "春節";

        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        protected override int ChineseMonth { get; } = 1;

        protected override int ChineseDay { get; } = 1;

        public override string I18NIdentityCode { get; } = "i18n_holiday_tw_chunjie";
    }
}