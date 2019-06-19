using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.UnitedStates.Public
{
    public class MlkDay : WeekOffsetVariableHolidayFunc
    {
        public override Country Country { get; } = Country.UnitedStates;

        public override Country BelongsToCountry { get; } = Country.UnitedStates;

        /// <summary>
        /// Martin Luther King, Jr. Day
        /// </summary>
        public override string Name { get; } = "Martin Luther King, Jr. Day";

        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        public override int Month { get; } = 1;

        protected override int WeekAtMonth { get; } = 3;

        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Monday;

        public override string I18NIdentityCode { get; } = "i18n_holiday_us_mlk";

        public override int? Since { get; } = 1986;
    }
}