using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Jersey.Bank
{
    /// <summary>
    /// Early May Bank Holiday
    /// </summary>
    public class EarlyMayBankHoliday : WeekOffsetVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Jersey;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.UnitedKingdom;

        /// <inheritdoc />
        public override string Name { get; } = "Spring Bank Holiday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Bank;

        /// <inheritdoc />
        public override int Month { get; } = 5;

        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 1;

        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Monday;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_je_early_may_bank";
    }
}