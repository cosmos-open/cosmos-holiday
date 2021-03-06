using System;
using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Extensions;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Oceania.Australia.Religion
{
    /// <summary>
    /// Boxing Day
    /// </summary>
    public class BoxingDay : BaseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Australia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Australia;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string>
        {
            "AU-ACT", "AU-NSW", "AU-NT", "AU-QLD", "AU-TAS", "AU-VIC", "AU-WA"
        };

        /// <inheritdoc />
        public override string Name { get; } = "Boxing Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_au_boxing";

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            var caculationDate = DateTimeFactory.Create(year, 12, 26);
            bool isSundayOrMonday =
                caculationDate.DayOfWeek == DayOfWeek.Sunday ||
                caculationDate.DayOfWeek == DayOfWeek.Monday;

            caculationDate = caculationDate.Shift(saturday => saturday.AddDays(2), sunday => sunday.AddDays(1));

            if (isSundayOrMonday)
                caculationDate = caculationDate.AddDays(1);

            return DailyAnswerBuilder
                .Create(Name, HolidayType)
                .From(caculationDate)
                .Country(Country.ToCode(), GetRegionCodeList())
                .I18N(I18NIdentityCode)
                .Build(year);
        }
    }
}