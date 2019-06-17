using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

/*
 * Hong Kong, a part of China
 * 香港，中华人民共和国的一部分
 */

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.HongKong.Tradition
{
    public class ChineseNewYear : ChineseVariableHolidayFunc
    {
        public override Country Country { get; set; } = Country.HongKong;

        public override Country BelongsToCountry { get; set; } = Country.China;

        /// <summary>
        /// Chinese New Year / Spring Festival
        /// </summary>
        public override string Name { get; } = "春節";

        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        protected override  int ChineseMonth { get; } = 1;

        protected override  int ChineseDay { get; } = 1;

        public override string I18NIdentityCode { get; } = "i18n_holiday_hk_chunjie";
    }
}