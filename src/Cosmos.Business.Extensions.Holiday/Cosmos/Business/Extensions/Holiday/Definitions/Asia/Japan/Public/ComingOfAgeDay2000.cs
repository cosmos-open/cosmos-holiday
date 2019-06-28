using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Japan.Public
{
    /// <summary>
    /// Coming of Age Day
    /// </summary>
    public class ComingOfAgeDay : WeekOffsetVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Japan;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Japan;

        /// <inheritdoc />
        public override string Name { get; } = "成人の日";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;
        
        /// <inheritdoc />
        public override int Month { get; } = 1;

        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 2;

        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Monday;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_jp_comingofage";

        /// <inheritdoc />
        public override int? Since { get; } = 2000;
    }
}