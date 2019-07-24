using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Propaganda
{
    /// <summary>
    /// 国际消费者权益日
    /// </summary>
    public class WorldConsumerRightsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.China;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.China;

        /// <inheritdoc />
        public override string Name { get; } = "国际消费者权益日";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Propaganda;

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 15;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_315";

        /*
         * “国际消费者权益日” (World Consumer Rights Day) 是每年的3月15日，
         * 由国际消费者联盟组织于1983年确定，目的在于扩大消费者权益保护的宣传，
         * 使之在世界范围内得到重视，以促进各国和地区消费者组织之间的合作与交往，
         * 在国际范围内更好地保护消费者权益。中消协发布了2019年消费维权年主题，
         * 主题为“信用让消费更放心”。
         */

        /// <inheritdoc />
        public override int? Since { get; } = 1983;
    }
}