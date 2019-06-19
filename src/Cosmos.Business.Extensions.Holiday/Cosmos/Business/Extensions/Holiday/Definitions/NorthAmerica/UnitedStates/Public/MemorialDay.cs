using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.UnitedStates.Public
{
    public class MemorialDay : BaseVariableHolidayFunc
    {
        public override Country Country { get; } = Country.UnitedStates;

        public override Country BelongsToCountry { get; } = Country.UnitedStates;

        /// <summary>
        /// Memorial Day
        /// </summary>
        public override string Name { get; } = "Memorial Day";

        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        public override string I18NIdentityCode { get; } = "i18n_holiday_us_memorialday";

        public override int? Since { get; } = 1868;

        public override DailyAnswer ToDailyAnswer(int year)
        {
            var calculationDay = DateTimeFactory.FindLastDay(year, 5, DayOfWeek.Monday);
            return DailyAnswerBuilder.Create(Name).From(calculationDay).I18N(I18NIdentityCode).Build(year);
        }
    }
}