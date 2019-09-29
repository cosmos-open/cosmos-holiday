using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.School
{
    /// <summary>
    /// 教师节 Teachers' Day 
    /// </summary>
    public class TeachersDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.China;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.China;

        /// <inheritdoc />
        public override string Name { get; } = "教师节";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.School;

        /// <inheritdoc />
        public override int Month { get; set; } = 9;

        /// <inheritdoc />
        public override int Day { get; set; } = 10;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_jiaoshi";

        /// <inheritdoc />
        public override int? Since { get; set; } = 1985;

        /*
         * 教师节，旨在肯定教师为教育事业所做的贡献。在中国近现代史上，
         * 多次以不同的日期作为过教师节。直至1985年，第六届全国人大常
         * 委会第九次会议通过了国务院关于建立教师节的议案，才真正确定
         * 了1985年9月10日为中国第一个教师节。
         */
    }
}