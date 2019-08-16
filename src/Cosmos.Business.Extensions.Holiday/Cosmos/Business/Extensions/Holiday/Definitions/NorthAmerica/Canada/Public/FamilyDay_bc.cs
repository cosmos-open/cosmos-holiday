using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Extensions;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Canada.Public
{
    /// <summary>
    /// Family Day
    /// </summary>
    public class FamilyDayBc : BaseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Canada;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Canada;

        /// <inheritdoc />
        public override string RegionCode { get; } = "CA-BC";

        /// <inheritdoc />
        public override string Name { get; } = "Family Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ca_family_bc";

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            var calculationDay = DateTimeFactory.Create(year, 2, 1);

            if (year < 2019)
                calculationDay = OccurrenceHelper.FindOccurrenceOfDayOfWeek(calculationDay, DayOfWeek.Monday, 2);
            else
                calculationDay = OccurrenceHelper.FindOccurrenceOfDayOfWeek(calculationDay, DayOfWeek.Monday, 3);

            return DailyAnswerBuilder
                .Create(Name, HolidayType)
                .From(calculationDay)
                .Country(Country.ToCode(), GetRegionCodeList())
                .I18N(I18NIdentityCode)
                .Build(year);
        }
    }
}