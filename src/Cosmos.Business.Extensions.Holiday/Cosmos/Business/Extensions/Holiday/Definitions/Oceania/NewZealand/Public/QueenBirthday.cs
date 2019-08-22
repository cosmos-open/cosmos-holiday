using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Oceania.NewZealand.Public
{
    /// <summary>
    /// Queen's Birthday 
    /// </summary>
    public class QueenBirthday : WeekOffsetVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.NewZealand;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.NewZealand;

        /// <inheritdoc />
        public override string Name { get; } = "Queen's Birthday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_nz_queen";

        /// <inheritdoc />
        public override int Month { get; } = 6;

        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 1;

        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Monday;
    }
}