using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

/*
 * Hong Kong, a part of China
 * 香港，中华人民共和国的一部分
 */

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.HongKong.Public
{
    public class Christmas : BaseFixedHolidayFunc
    {
        public override Country Country { get; set; } = Country.HongKong;

        public override Country BelongsToCountry { get; set; } = Country.China;

        /// <summary>
        /// Christmas
        /// </summary>
        public override string Name { get; } = "聖誕節";

        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        public override int Month { get; set; } = 12;

        public override int Day { get; set; } = 25;

        /*
         * 圣诞节（Christmas）又称耶诞节，译名为“基督弥撒”，它源自古罗马人迎接新年的农神节，
         * 与基督教本无关系。在基督教盛行罗马帝国后，教廷随波逐流地将这种民俗节日纳入基督教
         * 体系，同时以庆祝耶稣的降生。但在圣诞节这天不是耶稣的生辰，因为《圣经》未有记载耶稣
         * 具体生于哪天，同样没提到过有此种节日，是基督教吸收了古罗马神话的结果。
         *
         * 大部分的天主教教堂都会先在12月24日的平安夜，亦即12月25日凌晨举行子夜弥撒，而一些基
         * 督教会则会举行报佳音，然后在12月25日庆祝圣诞节；基督教的另一大分支——东正教的圣诞节
         * 庆则在每年的1月7日。
         *
         * 圣诞节也是西方世界以及其他很多地区的公共假日，例如：在亚洲的中国香港和澳门地区、马
         * 来西亚、新加坡。
         */

        public override string I18NIdentityCode { get; } = "i18n_holiday_hk_xmas";

    }
}