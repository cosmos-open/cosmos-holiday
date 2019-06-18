using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

/*
 * Macao, a part of China
 * 澳门，中华人民共和国的一部分
 */

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Macao.Public
{
    public class NationalDay : BaseFixedHolidayFunc
    {
        public override Country Country { get; } = Country.Macao;

        public override Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// National Day
        /// </summary>
        public override string Name { get; } = "國慶節";

        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        public override int Month { get; set; } = 10;

        public override int Day { get; set; } = 1;

        public override string I18NIdentityCode { get; } = "i18n_holiday_mo_guoqing";

        public override int? Since { get; } = 1949;
    }
}