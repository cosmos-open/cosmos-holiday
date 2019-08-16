using System;
using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Canada.Public
{
    /// <summary>
    /// Victoria Day, Monday on or before May 24
    /// </summary>
    public class VictoriaDay : BaseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Canada;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Canada;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string>
        {
            "CA-AB", "CA-BC", "CA-MB", "CA-NB", "CA-NT", "CA-NS",
            "CA-NU", "CA-ON", "CA-PE", "CA-SK", "CA-YT"
        };

        /// <inheritdoc />
        public override string Name { get; } = "Victoria Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ca_victoria";

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            var calculationDay = DateTimeFactory.Create(year, 5, 24);
            while (calculationDay.DayOfWeek != DayOfWeek.Monday)
                calculationDay = calculationDay.AddDays(-1);

            return DailyAnswerBuilder
                .Create(Name, HolidayType)
                .From(calculationDay)
                .Country(Country.ToCode(), GetRegionCodeList())
                .I18N(I18NIdentityCode)
                .Build(year);
        }
    }
}