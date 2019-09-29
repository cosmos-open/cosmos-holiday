using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

/*
 * Taiwan, a part of China
 * 台湾，中华人民共和国的一部分
 */

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Taiwan.Commemoration
{
    /// <summary>
    /// 父亲节
    /// <br />
    /// Father's Day
    /// </summary>
    public class FathersDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Taiwan;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.China;

        /// <inheritdoc />
        public override string Name { get; } = "父親節";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 8;

        /// <inheritdoc />
        public override int Day { get; set; } = 8;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_tw_fuqinjie";

        /*
         * 父亲节并非“泊来”的节日，中国也有自己的父亲节，中国的父亲节起源，要追溯到民国时期，
         * 1945年8月8日，上海发起了庆祝父亲节的活动，市民立即响应，抗日战争胜利后，上海市各
         * 界名流，联名请上海市政府转呈中央政府，定“爸爸 ”谐音的8月8日为全国性的父亲节，在
         * 父亲节这天，人们佩带鲜花，表达对父亲的敬重和思念。
         *
         * 时为1945年8月6日，上海《申报》刊文《八八父亲节缘起》。文章称：美国为纪念欧战中阵
         * 亡将士的妻与母，曾发起创立母亲节。而今，中国也应该发起创立自己的父亲节。因“父”字
         * 形同“八八”，且“八八”读音也与“爸爸”相同，故号召上海市民，一同来过“八八父亲节”。当
         * 时，日军虽败局已定，但尚未投降，上海仍在其控制之下，这一倡议“暗中表示怀念祖国之意”，
         * 实有风险。文章末尾，公开署名的首倡者共10人，分别是：颜惠庆、袁希濂、陈青士、梅兰芳、
         * 史致富、严独鹤、费穆、陆干臣、富文寿、张一渠。
         *
         * 上述诸人，均系名流，虽久处沦陷区，但爱国之志仍存。如颜惠庆于北洋时代，曾任外交总长、
         * 署理国务总理等职，1941年12月香港沦陷，遭日军所执，次年被迫返回上海，坚持不出任汪伪
         * 政府任何的官方职务。
         *
         * 1945年的这次民间发起的“父亲节”活动，影响范围有限。至1946年5月，又有上海名流潘公展、
         * 李石曾、宋汉章、王晓籁、杜月笙、吴稚晖、李登辉（原复旦大学校长）、钱永铭等数十人，
         * 联名向国民政府请求定每年的8月8日为“父亲节”。
         */

        /// <inheritdoc />
        public override int? Since { get; set; } = 1945;
    }
}