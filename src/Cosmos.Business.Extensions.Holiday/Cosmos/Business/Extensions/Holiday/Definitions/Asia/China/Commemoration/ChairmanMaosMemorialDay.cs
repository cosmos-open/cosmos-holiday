using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Commemoration
{
    /// <summary>
    /// Chairman Mao's Memorial Day
    /// </summary>
    public class ChairmanMaosMemorialDay : BaseFixedHolidayFunc
    {
        /// <summary>
        /// Country
        /// </summary>
        public override Country Country { get; } = Country.China;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// 毛泽东同志逝世纪念日
        /// </summary>
        public override string Name { get; } = "毛泽东同志逝世纪念日";

        /// <summary>
        /// Type of holiday
        /// </summary>
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <summary>
        /// Month
        /// </summary>
        public override int Month { get; set; } = 9;

        /// <summary>
        /// Day
        /// </summary>
        public override int Day { get; set; } = 9;

        /// <summary>
        /// i18n
        /// </summary>
        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_mao_shishi";

        /// <summary>
        /// Since...
        /// </summary>
        public override int? Since { get; } = 1976;

    }
}