using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Public
{
    /// <summary>
    /// CPC Founding day 中国共产党建党日 CPC Founding Day
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class CPCFoundingDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.China;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.China;

        /// <inheritdoc />
        public override string Name { get; } = "建党节";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 7;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_cpc71";

        /*
         * 中国共产党于1921年7月23日成立后，在反动军阀政府的残暴统
         * 治之下，只能处于秘密状态，没有公开进行活动的环境。在大革
         * 命时期，党忙于国共合作、开展工农运动和支援北伐战争，没有
         * 条件对党的诞生进行纪念。把7月1日作为中国共产党的诞辰纪念
         * 日，是毛泽东同志于1938年5月提出来的。当时，毛泽东在《论
         * 持久战》一文中提出：“今年七月一日，是中国共产党建立的十
         * 七周年纪念日”。这是中央领导同志第一次明确提出“七一”是党
         * 的诞生纪念日。
         *
         * 2016年7月1日，庆祝中国共产党成立95周年大会在北京人民大
         * 会堂隆重举行。
         */

        /// <inheritdoc />
        public override int? Since { get; set; } = 1938;
    }
}