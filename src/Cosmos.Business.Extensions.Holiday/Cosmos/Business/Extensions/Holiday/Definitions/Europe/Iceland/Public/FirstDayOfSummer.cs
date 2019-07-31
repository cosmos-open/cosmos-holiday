using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Iceland.Public
{
    /// <summary>
    /// First Day of Summer
    /// </summary>
    public class FirstDayOfSummer : BaseVariableHolidayFunc
    {

        /// <inheritdoc />
        public override Country Country { get; } = Country.Iceland;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Iceland;

        /// <inheritdoc />
        public override string Name { get; } = "Sumardagurinn fyrsti";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_is_first_day_of_summer";

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            var calculationDay = DateTimeFactory.FindNextDay(year, 4, 19, DayOfWeek.Thursday);

            var builder = DailyAnswerBuilder
                .Create(Name, HolidayType)
                .From(calculationDay)
                .Country(Country.ToCode(), GetRegionCodeList())
                .I18N(I18NIdentityCode);

            return builder.Build(year);
        }
    }
}