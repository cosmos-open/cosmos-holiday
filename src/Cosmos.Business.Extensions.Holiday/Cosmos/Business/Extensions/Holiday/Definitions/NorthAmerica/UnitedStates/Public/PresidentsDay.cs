using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.UnitedStates.Public
{
    public class PresidentsDay : WeekOffsetVariableHolidayFunc
    {
        public override Country Country { get; } = Country.UnitedStates;

        public override Country BelongsToCountry { get; } = Country.UnitedStates;

        /// <summary>
        /// Washington's Birthday
        /// </summary>
        public override string Name { get; } = "President's Day";

        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        public override int Month { get; } = 2;

        protected override int WeekAtMonth { get; } = 3;

        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Monday;

        public override string I18NIdentityCode { get; } = "i18n_holiday_us_president";

        public override int? Since { get; } = 1968;
    }
}