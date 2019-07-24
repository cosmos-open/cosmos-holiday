using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Commemoration
{
    /// <summary>
    /// 918
    /// </summary>
    public class _0918 : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.China;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.China;

        /// <inheritdoc />
        public override string Name { get; } = "九·一八事变纪念日";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 9;

        /// <inheritdoc />
        public override int Day { get; set; } = 18;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_918";

        /// <inheritdoc />
        public override int? Since { get; } = 1931;

        /*
         * 九一八事变（又称奉天事变、柳条湖事件）是日本在中国东北蓄意制造并发动的一场侵华战争，
         * 是日本帝国主义侵华的开端。
         *
         * 1931年9月18日夜，在日本关东军安排下，铁道“守备队”炸毁沈阳柳条湖附近的南满铁路路轨
         * （沙俄修建，后被日本所占），         * 并栽赃嫁祸于中国军队。日军以此为借口，
         * 炮轰沈阳北大营，是为“九一八事变”。次日，日军侵占沈阳，又陆续侵占了东北三省。
         * 1932年2月，东北全境沦陷。此后，日本在中国东北建立了伪满洲国傀儡政权，
         * 开始了对东北人民长达14年之久的奴役和殖民统治。
         *
         * “九一八事变”是日本帝国主义长期以来推行对华侵略扩张政策的必然的结果，
         * 也是企图把中国变为其独占的殖民地而采取的重要步骤。
         * 它同时标志着世界反法西斯战争的开始，揭开了第二次世界大战东方战场的序幕。
         *
         * https://baike.baidu.com/item/%E4%B9%9D%C2%B7%E4%B8%80%E5%85%AB%E4%BA%8B%E5%8F%98/2573930?fr=aladdin
         * http://baike.chinaso.com/wiki/doc-view-6578.html
         */
    }
}