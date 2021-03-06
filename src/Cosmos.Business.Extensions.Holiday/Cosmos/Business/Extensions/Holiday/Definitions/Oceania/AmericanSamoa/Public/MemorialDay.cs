using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Oceania.AmericanSamoa.Public
{
    /// <summary>
    /// Memorial Day
    /// </summary>
    public class MemorialDay : BaseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.AmericanSamoa;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.UnitedStates;

        /// <inheritdoc />
        public override string Name { get; } = "Memorial Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_as_memorial";

        /// <inheritdoc />
        public override int? Since { get; } = 1868;

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            var calculationDay = DateTimeFactory.FindLastDay(year, 5, DayOfWeek.Monday);
            return DailyAnswerBuilder
                .Create(Name, HolidayType)
                .From(calculationDay)
                .Country(Country.ToCode(), GetRegionCodeList())
                .I18N(I18NIdentityCode)
                .Build(year);
        }
    }
}