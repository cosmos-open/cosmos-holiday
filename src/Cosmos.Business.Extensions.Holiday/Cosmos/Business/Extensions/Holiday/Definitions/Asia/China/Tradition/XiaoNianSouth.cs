using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Tradition
{
    public class XiaoNianSouth : ChineseVariableHolidayFunc
    {
        public override Country Country { get; } = Country.China;

        public override Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// 12-24
        /// </summary>
        public override string Name { get; } = "南方小年(掸尘)";

        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        protected override int ChineseMonth { get; } = 12;

        protected override int ChineseDay { get; } = 24;

        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_nanfangxiaonian";
    }
}