using System;
using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Jersey.Bank
{
    /// <summary>
    /// Summer Bank Holiday for GB-ENG and GB-WLS
    /// </summary>
    public class SummerBankHoliday : BaseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Jersey;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.UnitedKingdom;

        /// <inheritdoc />
        public override string Name { get; } = "Late Summer Bank Holiday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Bank;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_je_summer_bank";

        /// <inheritdoc />
        public override int? Since { get; } = 1971;

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            var calculationDay = DateTimeFactory.FindLastDay(year, 8, DayOfWeek.Monday);
            return DailyAnswerBuilder
                .Create(Name, HolidayType)
                .From(calculationDay)
                .Country(Country.ToCode(), GetRegionCodeList())
                .I18N(I18NIdentityCode)
                .Build(year);
        }
    }
}