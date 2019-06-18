using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Commemoration
{
    public class ChairmanMaosBirthday : BaseFixedHolidayFunc
    {
        public override Country Country { get; } = Country.China;

        public override Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// 毛泽东同志诞辰纪念日
        /// </summary>
        public override string Name { get; } = "毛泽东同志诞辰纪念日";

        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        public override int Month { get; set; } = 12;

        public override int Day { get; set; } = 26;

        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_mao_danchen";

        public override int? Since { get; } = 1893;
    }
}