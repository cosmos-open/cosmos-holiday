using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Zambia.Public
{
    /// <summary>
    /// Unity Day
    /// </summary>
    public class UnityDay : BaseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Zambia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Zambia;

        /// <inheritdoc />
        public override string Name { get; } = "Unity Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_zm_unity";

        /// <summary>
        /// Convert to <see cref="DailyAnswer"/>
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public override DailyAnswer ToDailyAnswer(int year)
        {
            var date = DateTimeFactory.OffsetByWeek(year, 7, 1, DayOfWeek.Monday).AddDays(1);

            var builder = DailyAnswerBuilder.Create(Name, HolidayType).From(date);
            
            if (Since.HasValue)
                builder.Since(Since.Value);

            if (End.HasValue)
                builder.End(End.Value);

            if (TimeStepValue.HasValue)
                builder.Times(TimeStepValue.Value);

            builder.Country(Country.ToCode(), GetRegionCodeList());

            return builder.I18N(I18NIdentityCode).Build(year);
        }
    }
}