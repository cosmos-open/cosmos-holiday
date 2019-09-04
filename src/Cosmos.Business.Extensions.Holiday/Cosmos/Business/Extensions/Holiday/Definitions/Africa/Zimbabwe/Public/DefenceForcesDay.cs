using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Zimbabwe.Public
{
    /// <summary>
    /// Defence Forces Day
    /// </summary>
    public class DefenceForcesDay : WeekOffsetVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Zimbabwe;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Zimbabwe;

        /// <inheritdoc />
        public override string Name { get; } = "Defence Forces Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Propaganda;

        /// <inheritdoc />
        public override int Month { get; } = 8;

        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 2;

        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Tuesday;
        
        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_zw_defence_forces";
    }
}