using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Oceania.AmericanSamoa.Commemoration
{
    /// <summary>
    /// Mother's Day
    /// </summary>
    public class MothersDay : WeekOffsetVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.AmericanSamoa;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.UnitedStates;

        /// <inheritdoc />
        public override string Name { get; } = "Mother's Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; } = 5;

        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 2;

        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Sunday;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_as_mother";

        /*
         * 1914年，美国参众两议院将每年5月第2个星期日定为母亲节。
         */

        /// <inheritdoc />
        public override int? Since { get; } = 1914;
    }
}