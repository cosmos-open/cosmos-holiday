using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Public
{
    /// <summary>
    /// 中国人民抗日战争胜利纪念日
    /// </summary>
    public class ResistanceAgainstJapanDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.China;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// Chinese people's war of resistance against Japan
        /// </summary>
        public override string Name { get; } = "中国人民抗日战争胜利纪念日";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 9;

        /// <inheritdoc />
        public override int Day { get; set; } = 3;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_93";

        /*
         * 中国人民抗日战争胜利纪念日是于2014年2月27日下午十二届全国人大常委会第七次会议经表决通过，
         * 将9月3日确定为中国人民抗日战争胜利纪念日。
         *
         * 1945年9月2日，日本向盟军投降仪式在东京湾密苏里号军舰上举行。
         * 在包括中国在内的9个受降国代表注视下，日本在投降书上签字。
         * 这是中国近代以来反侵略历史上的第一次全面胜利，也为世界反法西斯战争的胜利做出了巨大贡献。
         * 之后每年的9月3日，被确定为中国人民抗日战争胜利纪念日。
         *
         * 初设时间      1946年4月
         * 法定确认时间  2014年2月27日
         * */

        /// <inheritdoc />
        public override int? Since { get; } = 1946;
    }
}