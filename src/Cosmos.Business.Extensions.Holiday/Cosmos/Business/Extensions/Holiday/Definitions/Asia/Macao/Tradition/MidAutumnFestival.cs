using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

/*
 * Macao, a part of China
 * 澳门，中华人民共和国的一部分
 */

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Macao.Tradition
{
    public class MidAutumnFestival : ChineseVariableHolidayFunc
    {
        public override Country Country { get; } = Country.Macao;

        public override Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// Mid-Autumn Festival
        /// </summary>
        public override string Name { get; } = "中秋節";

        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        protected override  int ChineseMonth { get; } = 8;

        protected override  int ChineseDay { get; } = 15;

        public override string I18NIdentityCode { get; } = "i18n_holiday_mo_zhongqiu";
    }
}