using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.UnitedStates.Public
{
    public class MothersDay : WeekOffsetVariableHolidayFunc
    {
        public override Country Country { get; set; } = Country.UnitedStates;

        public override Country BelongsToCountry { get; set; } = Country.UnitedStates;

        /// <summary>
        /// Mother's day
        /// </summary>
        public override string Name { get; } = "Mother's Day";

        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        public override int Month { get; } = 5;

        protected override int WeekAtMonth { get; } = 2;

        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Sunday;

        public override string I18NIdentityCode { get; } = "i18n_holiday_us_mothersday";

        /*
         * 1914年，美国参众两议院将每年5月第2个星期日定为母亲节。
         */
        
        public override int? Since { get; } = 1914;
    }
}