using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Commemoration
{
    /// <summary>
    /// Mother's day
    /// </summary>
    public class MothersDay : WeekOffsetVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.China;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// Mother's day
        /// </summary>
        public override string Name { get; } = "母亲节";

        /// <summary>
        /// Type of holiday
        /// </summary>
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <summary>
        /// Month
        /// </summary>
        public override int Month { get; } = 5;

        /// <summary>
        /// Week at month
        /// </summary>
        protected override int WeekAtMonth { get; } = 2;

        /// <summary>
        /// Day of week
        /// </summary>
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Sunday;

        /// <summary>
        /// i18n
        /// </summary>
        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_muqinjie";

        /*
         * 1914年，美国参众两议院将每年5月第2个星期日定为母亲节。
         * 我国国内民间约定成俗，故使用美国 1914 年作为起始年份
         */

        /// <summary>
        /// Since...
        /// </summary>
        public override int? Since { get; } = 1914;
    }
}