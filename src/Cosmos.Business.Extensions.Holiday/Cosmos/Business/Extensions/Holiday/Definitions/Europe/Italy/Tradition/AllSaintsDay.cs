using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Italy.Tradition
{
    /// <summary>
    /// All Saints' Day
    /// </summary>
    public class AllSaintsDay : WeekOffsetVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Italy;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Italy;

        /// <inheritdoc />
        public override string Name { get; } = "Tutti i santi";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        /// <inheritdoc />
        public override int Month { get; } = 11;

        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 1;

        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Saturday;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_it_all_saints";
    }
}