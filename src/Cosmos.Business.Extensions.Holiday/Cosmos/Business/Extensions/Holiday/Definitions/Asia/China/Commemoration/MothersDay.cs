using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Commemoration
{
    public class MothersDay : WeekOffsetVariableHolidayFunc
    {
        public override Country Country { get; } = Country.China;

        public override Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// Mother's day
        /// </summary>
        public override string Name { get; } = "母亲节";

        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        public override int Month { get; } = 5;

        protected override int WeekAtMonth { get; } = 2;

        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Sunday;

        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_muqinjie";

        /*
         * 1914年，美国参众两议院将每年5月第2个星期日定为母亲节。
         * 我国国内民间约定成俗，故使用美国 1914 年作为起始年份
         */

        public override int? Since { get; } = 1914;
    }
}