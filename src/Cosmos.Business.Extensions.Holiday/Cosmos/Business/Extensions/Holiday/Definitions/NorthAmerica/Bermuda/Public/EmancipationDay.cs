using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Bermuda.Public
{
    /// <summary>
    /// Emancipation Day
    /// </summary>
    public class EmancipationDay : BaseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bermuda;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.UnitedKingdom;

        /// <inheritdoc />
        public override string Name { get; } = "Emancipation Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bm_emancipation_day";

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            return DailyAnswerBuilder
                .Create(Name, HolidayType)
                .From(DateTimeFactory.FindDayBefore(year, 8, 4, DayOfWeek.Thursday))
                .Country(Country.ToCode(), GetRegionCodeList())
                .I18N(I18NIdentityCode)
                .Build(year);
        }
    }
}