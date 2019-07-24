using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Public
{
    /// <summary>
    /// May day
    /// </summary>
    public class MayDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.China;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// International Workers' Day / May Day
        /// </summary>
        public override string Name { get; } = "国际劳动节";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_51";

        /*
        * 国际劳动节又称“五一国际劳动节”、“国际示威游行日”（International Workers' Day或者May Day），
         * 是世界上80多个国家的全国性节日。定在每年的五月一日。它是全世界劳动人民共同拥有的节日。
         *
         * 1889年7月，由恩格斯领导的第二国际在巴黎举行代表大会。
         * 会议通过决议，规定1890年5月1日国际劳动者举行游行，并决定把5月1日这一天定为国际劳动节。
         * 
         * 中央人民政府政务院于1949年12月作出决定，将5月1日确定为劳动节。
         * 1989年后，国务院基本上每5年表彰一次全国劳动模范和先进工作者，每次表彰3000人左右。
         * 2019年3月22日，国务院办公厅调整2019年劳动节假期安排，2019年5月1日至4日放假调休，共4天。
        */
    }
}