using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.UnitedStates.Religion
{
    public class ThanksgivingDay : WeekOffsetVariableHolidayFunc
    {
        public override Country Country { get; } = Country.UnitedStates;

        public override Country BelongsToCountry { get; } = Country.UnitedStates;

        /// <summary>
        /// Thanksgiving Day
        /// </summary>
        public override string Name { get; } = "Thanksgiving Day";

        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        public override int Month { get; } = 11;

        protected override int WeekAtMonth { get; } = 4;

        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Thursday;

        public override string I18NIdentityCode { get; } = "i18n_holiday_us_thanksgivingday";

        public override int? Since { get; } = 1863;

    }
}