using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Propaganda
{
    /// <summary>
    /// Arbor day
    /// </summary>
    public class ArborDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.China;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.China;

        /// <inheritdoc />
        public override string Name { get; } = "植树节";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Propaganda;

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 12;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_312";

        /*
         * 植树节是按照法律规定宣传保护树木，并组织动员群众积极参加以植树造林为活动内容的节日。
         * 按时间长短可分为植树日、植树周和植树月，共称为国际植树节。提倡通过这种活动，激发人们
         * 爱林造林的热情、意识到环保的重要性。
         *
         * 中国的植树节由凌道扬和韩安、裴义理等林学家于1915年倡议设立，最初将时间确定在每年清明
         * 节。1928年，国民政府为纪念孙中山逝世三周年将植树节改为3月12日。新中国成立后的1979年，
         * 在邓小平提议下，第五届全国人大常委会第六次会议决定每年3月12日为我国的植树节。
         */

        /// <inheritdoc />
        public override int? Since { get; set; } = 1979;
    }
}