using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.UnitedStates.Public
{
    public class LaborDay : WeekOffsetVariableHolidayFunc
    {
        public override Country Country { get; } = Country.UnitedStates;

        public override Country BelongsToCountry { get; } = Country.UnitedStates;

        /// <summary>
        /// Labor Day
        /// </summary>
        public override string Name { get; } = "Labor Day";

        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        public override int Month { get; } = 9;

        protected override int WeekAtMonth { get; } = 1;

        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Monday;

        public override string I18NIdentityCode { get; } = "i18n_holiday_us_laborday";

        public override int? Since { get; } = 1894;
    }
}