using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Public
{
    /// <summary>
    /// 8-1
    /// </summary>
    public class ArmyDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.China;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.China;

        /// <inheritdoc />
        public override string Name { get; } = "建军节";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 8;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_pla81";

        /*
         * 八一建军节是中国人民解放军建军纪念日，每年的八月一日举行，
         * 由中国人民革命军事委员会设立，为纪念中国工农红军成立的节日。
         *
         * 1933年7月11日，中华苏维埃共和国临时中央政府根据中央革命军
         * 事委员会6月30日的建议，决定8月1日为中国工农红军成立纪念日。
         * 1949年6月15日，中国人民革命军事委员会发布命令，以“八一”两字
         * 作为中国人民解放军军旗和军徽的主要标志。中华人民共和国成立
         * 后，将此纪念日改称为中国人民解放军建军节。
         */

        /// <inheritdoc />
        public override int? Since { get; set; } = 1933;
    }
}