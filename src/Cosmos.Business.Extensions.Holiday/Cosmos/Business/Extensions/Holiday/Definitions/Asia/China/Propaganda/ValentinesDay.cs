using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Propaganda
{
    /// <summary>
    /// 情人节
    /// </summary>
    public class ValentinesDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.China;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.China;

        /// <inheritdoc />
        public override string Name { get; } = "情人节";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Propaganda;

        /// <inheritdoc />
        public override int Month { get; set; } = 2;

        /// <inheritdoc />
        public override int Day { get; set; } = 14;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_214";

        /*
         * 情人节又叫圣瓦伦丁节或圣华伦泰节，即每年的2月14日，
         * 是西方国家的传统节日之一，起源于基督教。
         * 这是一个关于爱、浪漫以及花、巧克力、贺卡的节日
         * 男女在这一天互送礼物用以表达爱意或友好。
         * 情人节的晚餐约会通常代表了情侣关系的发展关键。
         * 现已成为欧美各国青年人喜爱的节日，其他国家也已开始流行。
         *
         * 而在中国，传统节日之一的七夕节也是姑娘们重视的日子，
         * 因此而被称为中国的情人节。由于能表达共同的人类情怀，
         * 各国各地纷纷发掘了自身的“情人节”。
         *
         * 据海外网2019年2月14日电，有美媒曝出，日本女性正在抵制本国情人节的一项独特传统。
         */
    }
}