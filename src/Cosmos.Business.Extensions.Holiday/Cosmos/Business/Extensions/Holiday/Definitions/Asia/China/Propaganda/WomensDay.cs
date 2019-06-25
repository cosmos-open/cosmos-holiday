using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Propaganda
{
    /// <summary>
    /// Women's day
    /// </summary>
    public class WomensDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.China;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// International Women's Day
        /// </summary>
        public override string Name { get; } = "国际妇女节";

        /// <summary>
        /// Type of holiday
        /// </summary>
        public override HolidayType HolidayType { get; set; } = HolidayType.Propaganda;

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 8;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_38";

        /*
         * 国际妇女节（International Women's Day，简写IWD）
         * 全称“联合国妇女权益和国际和平日”（United Nations women's
         * rights and international peace day），在中国又称“国际劳
         * 动妇女节”、“三八节”和“三八妇女节”。是在每年的3月8日为庆祝
         * 妇女在经济、政治和社会等领域做出的重要贡献和取得的巨大成就
         * 而设立的节日。
         *
         * 在不同的地区，庆祝的重点有所不同，从普通的庆祝对女性的尊重、
         * 欣赏和爱意到庆祝女性在经济、政治及社会领域的成就。由于这个
         * 节日一开始是社会主义女权主义者发起的政治事件，这个节日和众
         * 多国家的文化都有融合。
         *
         * 国际妇女节是全世界许多国家都庆祝的节日。这一天，妇女们作出
         * 的成就得到肯定，无论她们的国籍、民族、语言、文化、经济状况
         * 和政治立场如何。从那以后，国际妇女节成为一个全球性的妇女节
         * 日，对发达国家及发展中国家的妇女来说都具有新的意义。日益发
         * 展壮大的国际妇女运动，通过联合国四次妇女问题全球会议得以加
         * 强。在其推动下，纪念活动已成为一个号角，号召协力争取妇女权
         * 利和妇女对政治经济事务的参与。
         */

        /// <inheritdoc />
        public override int? Since { get; } = 1975;
    }
}