using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Moldova.Commemoration
{
    /// <summary>
    /// Memorial Day
    /// </summary>
    public class MemorialDay : BaseVariableHolidayFunc
    {

        /// <inheritdoc />
        public override Country Country { get; } = Country.Moldova;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Moldova;

        /// <inheritdoc />
        public override string Name { get; } = "Memorial Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_md_memorial";

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            return DailyAnswerBuilder
                .Create(Name, HolidayType)
                .From(DateTimeFactory.FindLastDay(year, 5, DayOfWeek.Monday))
                .I18N(I18NIdentityCode)
                .Country(Country.ToCode(), GetRegionCodeList())
                .Build(year);
        }
    }
}