using System;
using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Extensions;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Canada.Religion
{
    /// <summary>
    /// BoxingDay
    /// </summary>
    public class BoxingDay : BaseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Canada;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Canada;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string> {"CA-AB", "CA-NB", "CA-NS", "CA-ON", "CA-PE"};

        /// <inheritdoc />
        public override string Name { get; } = "Boxing Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ca_boxing";

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            var calculationDay = DateTimeFactory.Create(year, 12, 26);

            //if Xmas=Sun, it's shifted to Mon and 26 also gets shifted
            bool isSundayOrMonday =
                calculationDay.DayOfWeek == DayOfWeek.Sunday ||
                calculationDay.DayOfWeek == DayOfWeek.Monday;

            calculationDay = calculationDay.Shift(saturday => saturday.AddDays(2), sunday => sunday.AddDays(1));

            if (isSundayOrMonday)
                calculationDay = calculationDay.AddDays(1);

            return DailyAnswerBuilder
                .Create(Name, HolidayType)
                .From(calculationDay)
                .Country(Country.ToCode(), GetRegionCodeList())
                .I18N(I18NIdentityCode)
                .Build(year);
        }
    }
}