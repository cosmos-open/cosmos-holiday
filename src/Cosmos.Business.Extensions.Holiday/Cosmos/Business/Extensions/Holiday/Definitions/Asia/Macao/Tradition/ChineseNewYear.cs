using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

/*
 * Macao, a part of China
 * 澳门，中华人民共和国的一部分
 */

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Macao.Tradition
{
    public class ChineseNewYear : ChineseVariableHolidayFunc
    {
        public override Country Country { get; set; } = Country.Macao;

        public override Country BelongsToCountry { get; set; } = Country.China;

        /// <summary>
        /// Chinese New Year / Spring Festival
        /// </summary>
        public override string Name { get; } = "春節";

        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        protected override  int Month { get; } = 1;

        protected override  int Day { get; } = 1;

        public override string I18NIdentityCode { get; } = "i18n_holiday_mo_chunjie";
    }
}