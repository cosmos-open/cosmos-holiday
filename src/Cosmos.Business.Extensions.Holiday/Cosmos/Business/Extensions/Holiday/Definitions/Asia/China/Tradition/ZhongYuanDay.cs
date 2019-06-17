using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Tradition
{
    public class ZhongYuanDay : ChineseVariableHolidayFunc
    {
        public override Country Country { get; set; } = Country.China;

        public override Country BelongsToCountry { get; set; } = Country.China;

        /// <summary>
        /// 7-15
        /// </summary>
        public override string Name { get; } = "中元节";

        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        protected override int ChineseMonth { get; } = 7;

        protected override int ChineseDay { get; } = 15;

        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_zhongyuanjie";

        /*
         * 中元节，即七月半祭祖节，又称施孤、鬼节、斋孤、地官节，节日习俗主要有祭祖、放河灯、
         * 祀亡魂、焚纸锭等。中元节由上古时代“七月半”农作丰收秋尝祭祖演变而来。七月半是民间
         * 初秋庆贺丰收、酬谢大地的节日，有若干农作物成熟，民间按例要祀祖，用新米等祭供，向
         * 祖先报告秋成，是追怀先人的一种文化传统节日，其文化核心是敬祖尽孝。
         *
         * “七月半”原本是上古时代民间的祭祖节，而被称为“中元节”，则是源于东汉后道教的说法。
         * 道教认为七月半是地官诞辰，祈求地官赦罪之日，阴曹地府将放出全部鬼魂，已故祖先可
         * 回家团圆，因此将七月半秋尝祭祖节称为“中元节”；佛教中称为“盂兰盆节”。在统治者推
         * 崇道教的唐代，道教的中元节开始兴盛，并且逐渐将“中元”固定为节名相沿迄今。中元节
         * 与上元节、下元节合称“三元”。
         *
         * 七月十四/十五日祭祖是流行于汉字文化圈诸国以及海外华人地区的传统文化节日，与除夕、
         * 清明节、重阳节均是中华民族传统的祭祖大节。2010年5月，文化部将香港特区申报的“中
         * 元节（潮人盂兰胜会）”入选，列入国家级非物质文化遗产名录。
         */
    }
}