using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Nicaragua.Religion
{
    /// <summary>
    /// Holy Thursday
    /// </summary>
    public class HolyThursday : WeekOffsetVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Nicaragua;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Nicaragua;
        
        /// <inheritdoc />
        public override string Name { get; } = "Holy Thursday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ni_holy_thursday";

        /// <inheritdoc />
        public override int Month { get; } = 4;

        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 3;

        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Thursday;
    }
}