using System;
using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Oceania.Australia.Public
{
    /// <summary>
    /// Labour Day for AU-TAS and AU-VIC
    /// </summary>
    public class LabourDayTasVic : BaseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Australia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Australia;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string> {"AU-TAS", "AU-VIC"};

        /// <inheritdoc />
        public override string Name { get; } = "Labour Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_au_newyearsday_tas_vic";

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            return DailyAnswerBuilder
                .Create(Name)
                .From(DateTimeFactory.FindNextDay(year, 3, 1, DayOfWeek.Monday).AddDays(7))
                .Country(Country.ToCode(), GetRegionCodeList())
                .I18N(I18NIdentityCode)
                .Build(year);
        }
    }
}