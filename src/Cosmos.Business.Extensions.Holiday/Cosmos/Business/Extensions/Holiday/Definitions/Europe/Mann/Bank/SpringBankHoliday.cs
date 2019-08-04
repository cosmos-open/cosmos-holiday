using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Mann.Bank
{
    /// <summary>
    /// Spring Bank Holiday
    /// </summary>
    public class SpringBankHoliday : BaseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Mann;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.UnitedKingdom;

        /// <inheritdoc />
        public override string Name { get; } = "Spring Bank Holiday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Bank;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_im_spring_bank";

        /// <inheritdoc />
        public override int? Since { get; } = 1971;

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