using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Tradition
{
    /// <summary>
    /// 九九重阳节 Doubel Ninth Festival
    /// </summary>
    public class DoubleNinthFestival : ChineseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.China;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.China;

        /// <inheritdoc />
        public override string Name { get; } = "重阳节";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        /// <inheritdoc />
        protected override int ChineseMonth { get; } = 9;

        /// <inheritdoc />
        protected override int ChineseDay { get; } = 9;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_99";

        /*
         * 重阳节，为每年的农历九月初九日，是中国民间的传统节日。
         * 《易经》中把“九”定为阳数，“九九”两阳数相重，故曰“重阳”；因日与月皆逢九，故又称为“重九”。
         * 九九归真，一元肇始，古人认为九九重阳是吉祥的日子。古时民间在重阳节有登高祈福、秋游赏菊、
         * 佩插茱萸、拜神祭祖及饮宴求寿等习俗。传承至今，又添加了敬老等内涵，于重阳之日享宴高会，
         * 感恩敬老。登高赏秋与感恩敬老是当今重阳节日活动的两大重要主题。
         *
         * 据现存史料及考证， 重阳节的源头，可追溯到上古时代。古时季秋有丰收祭天、祭祀大火星活动。
         * 《吕氏春秋·季秋纪》有载，古人在九月农作物丰收之时祭天帝、祭祖，以谢天帝、祖先恩德的活动。
         * 这是重阳节作为秋季丰收祭祀活动而存在的原始形式。重阳节起始于上古，成型于春秋战国，普及于西汉，
         * 鼎盛于唐代以后。唐代是传统节日习俗揉合定型的重要时期，其主体部分传承至今。重阳祭祖民俗相沿数千年，
         * 是具有深刻意义的一个古老民俗。重阳节与除夕、清明节、七月半并称中国传统四大祭祖节日。 [3-7]
         *
         * 重阳节在历史发展演变中杂糅多种民俗为一体，承载了丰富的文化内涵。在民俗观念中“九”在数字中是最大数，
         * 有长久长寿的含意，寄托着人们对老人健康长寿的祝福。1989年，农历九月九日被定为“敬老节”，
         * 倡导全社会树立尊老、敬老、爱老、助老的风气。
         * 2006年5月20日，重阳节被国务院列入首批国家级非物质文化遗产名录。
         */
    }
}