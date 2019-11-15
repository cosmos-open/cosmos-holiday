using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Bermuda.Public
{
    /// <summary>
    /// Labour Day
    /// </summary>
    public class LabourDay : BaseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bermuda;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.UnitedKingdom;

        /// <inheritdoc />
        public override string Name { get; } = "Labour Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bm_labour";

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            return DailyAnswerBuilder
                .Create(Name, HolidayType)
                .From(DateTimeFactory.FindDayBefore(year, 9, 1, DayOfWeek.Monday))
                .Country(Country.ToCode(), GetRegionCodeList())
                .I18N(I18NIdentityCode)
                .Build(year);
        }
    }
}