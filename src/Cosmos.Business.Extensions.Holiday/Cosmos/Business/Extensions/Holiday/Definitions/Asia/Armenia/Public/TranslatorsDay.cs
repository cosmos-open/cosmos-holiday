using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Armenia.Public
{
    /// <summary>
    /// Translator's Day
    /// </summary>
    public class TranslatorsDay : WeekOffsetVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Armenia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Armenia;

        /// <inheritdoc />
        public override string Name { get; } = "Թարգմանչաց տոն";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; } = 10;

        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 2;

        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Saturday;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_am_translator";
    }
}