using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Tradition
{
    public class DoubleSeventhFestival: ChineseVariableHolidayFunc
    {
        public override Country Country { get; } = Country.China;

        public override Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// Doubel Seventh Festival
        /// </summary>
        public override string Name { get; } = "七夕节";

        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        protected override int ChineseMonth { get; } = 7;

        protected override int ChineseDay { get; } = 7;

        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_qixi";
    }
}