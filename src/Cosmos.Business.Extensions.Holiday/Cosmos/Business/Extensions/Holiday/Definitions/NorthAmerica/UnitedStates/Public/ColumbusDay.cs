using System;
using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.UnitedStates.Public
{
    public class ColumbusDay : WeekOffsetVariableHolidayFunc
    {
        public override Country Country { get; } = Country.UnitedStates;

        public override Country BelongsToCountry { get; } = Country.UnitedStates;

        public override List<string> RegionCodes { get; set; } = new List<string>
        {
            "US-AL", "US-AZ", "US-CO", "US-CT", "US-DC", "US-GA", "US-ID",
            "US-IL", "US-IN", "US-IA", "US-KS", "US-KY", "US-LA", "US-ME",
            "US-MD", "US-MA", "US-MS", "US-MO", "US-MT", "US-NE", "US-NH",
            "US-NJ", "US-NM", "US-NY", "US-NC", "US-OH", "US-OK", "US-PA",
            "US-RI", "US-SC", "US-TN", "US-UT", "US-VA", "US-WV"
        };

        /// <summary>
        /// Columbus Day
        /// </summary>
        public override string Name { get; } = "Columbus Day";

        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        public override int Month { get; } = 10;

        protected override int WeekAtMonth { get; } = 2;

        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Monday;

        public override string I18NIdentityCode { get; } = "i18n_holiday_us_columbusday";

        public override int? Since { get; } = 1937;

    }
}