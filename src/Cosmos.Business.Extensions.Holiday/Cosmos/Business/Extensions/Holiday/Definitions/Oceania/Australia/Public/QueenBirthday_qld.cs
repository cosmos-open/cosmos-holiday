using System;
using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Oceania.Australia.Public
{
    /// <summary>
    /// Queen's Birthday (varies by state)
    /// </summary>
    public class QueenBirthdayQld : BaseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Australia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Australia;

        /// <inheritdoc />
        public override string RegionCode { get; } = "AU-QLD";

        /// <inheritdoc />
        public override string Name { get; } = "Queen's Birthday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_au_queen_qld";

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            DateTime calculationTime;
            
            if (year == 2012 || year >= 2016)
            {
                calculationTime = DateTimeFactory.FindNextDay(year, 10, 1, DayOfWeek.Monday);
            }
            else
            {
                calculationTime = DateTimeFactory.OffsetByWeek(year, 6, 2, DayOfWeek.Monday);
            }
            
            return DailyAnswerBuilder
                .Create(Name, HolidayType)
                .From(calculationTime)
                .Country(Country.ToCode(), GetRegionCodeList())
                .I18N(I18NIdentityCode)
                .Build(year);
        }
    }
}