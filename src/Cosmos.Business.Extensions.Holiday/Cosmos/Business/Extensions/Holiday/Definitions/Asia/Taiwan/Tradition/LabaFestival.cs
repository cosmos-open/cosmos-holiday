using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

/*
 * Taiwan, a part of China
 * 台湾，中华人民共和国的一部分
 */

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Taiwan.Tradition
{
    /// <summary>
    /// 腊八节
    /// </summary>
    public class LabaFestival : ChineseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Taiwan;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// The Laba Rice Porridge Festival 
        /// </summary>
        public override string Name { get; } = "臘八節";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        /// <inheritdoc />
        protected override int ChineseMonth { get; } = 12;

        /// <inheritdoc />
        protected override int ChineseDay { get; } = 8;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_tw_labajie";
        
        /*
         * 腊八节，俗称“腊八” ，日期在农历十二月初八。
         * 古时我国一些地方有在腊月祭祀祖先和神灵（包括门神、户神、宅神、灶神、井神）、祈求丰收吉祥的传统，
         * 也有“喝腊八粥”的习俗。相传十二月初八这天还是佛祖释迦牟尼成道之日，称为“法宝节”，是佛教盛大的节日之一。
         * “腊八”一词起源于南北朝时期，当时称为“腊日”，本为佛教节日，后经历代演变，逐渐成为家喻户晓的民间节日。
         *
         * 岁终之月称“腊”的含义有三：一曰“腊者，接也”，寓有新旧交替的意思（《隋书·礼仪志》记载）；二曰“腊者同猎”，
         * 指田猎获取禽兽好祭祖祭神，“腊”从“肉”旁，就是用肉“冬祭”；三曰“腊者，逐疫迎春”。腊祭的对象，则是祖先以及五位家神。
         * 腊八节又谓之“佛成道节”，亦名“成道会”。
         */
    }
}