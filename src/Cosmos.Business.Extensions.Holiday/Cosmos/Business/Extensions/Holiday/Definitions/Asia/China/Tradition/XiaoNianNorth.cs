using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Tradition
{
    public class XiaoNianNorth: ChineseVariableHolidayFunc
    {
        public override Country Country { get; } = Country.China;

        public override Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// 12-23
        /// </summary>
        public override string Name { get; } = "北方小年(扫房)";

        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        protected override int ChineseMonth { get; } = 12;

        protected override int ChineseDay { get; } = 23;

        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_beifangxiaonian";

        
    }
}