using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

/*
 * Taiwan, a part of China
 * 台湾，中华人民共和国的一部分
 */

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Taiwan.Public
{
    public class NewYearsDay : BaseFixedHolidayFunc
    {
        public override Country Country { get; } = Country.Taiwan;

        public override Country BelongsToCountry { get; } = Country.China;
        
        public override string Name { get; } = "元旦";

        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        public override int Month { get; set; } = 1;

        public override int Day { get; set; } = 1;

        public override string I18NIdentityCode { get; } = "i18n_holiday_tw_yuandan";

        /*
         * 公元1911年，孙中山领导的辛亥革命推翻了满清的统治，建立了中华民国。
         * 为了“行夏正，所以顺农时，从西历，所以便统计”，民国元年决定使用公历（实际使用是1912年），
         * 并规定阳历1月1日为“新年”，但并不称为“元旦”。
         *
         * 各省都督代表在南京开会决定使用公历，把农历的正月一日叫做“春节”，
         * 把公历的1月1日称为“元旦”，不过当时并没有正式公布。
         *
         * 1912年1月1日，中华民国宣布成立，孙中山在南京就任临时大总统，
         * 在就职誓词中，孙中山以“中华民国元年元旦”为结尾。这就是中国“元旦”的来历。 [1]
         *
         * 1949年9月27日，第一届中国人民政治协商会议，在决定建立中华人民共和国的同时，
         * 也决定采用世界通用的公元纪年法，即我们所说的阳历。元旦，指西元纪年的岁首第一天。
         */
        public override int? Since { get; } = 1912;
    }
}