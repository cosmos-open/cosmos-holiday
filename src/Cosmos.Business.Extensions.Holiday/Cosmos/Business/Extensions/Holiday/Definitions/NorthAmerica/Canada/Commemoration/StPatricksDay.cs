using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Canada.Commemoration
{
    /// <summary>
    /// St. Patricks day (March 17)
    /// </summary>
    public class StPatricksDay : BaseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Canada;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Canada;

        /// <inheritdoc />
        public override string RegionCode { get; } = "CA-NL";

        /// <inheritdoc />
        public override string Name { get; } = "St. Patricks Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ca_patrick";

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            var calculationDay = DateTimeFactory.Create(year, 3, 17);

            calculationDay = OccurrenceHelper.FindNearestDayOfWeek(calculationDay, DayOfWeek.Monday);

            return DailyAnswerBuilder
                .Create(Name, HolidayType)
                .From(calculationDay)
                .Country(Country.ToCode(), GetRegionCodeList())
                .I18N(I18NIdentityCode)
                .Build(year);
        }
    }
}