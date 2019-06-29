using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.UnitedKingdom.Bank
{
    /// <summary>
    /// Early May Bank Holiday
    /// </summary>
    public class EarlyMayBank : BaseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.UnitedKingdom;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.UnitedKingdom;

        /// <inheritdoc />
        public override string Name { get; } = "Early May Bank Holiday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Bank;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gb_earlymaybank";

        /// <inheritdoc />
        public override int? Since { get; } = 1978;

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            DateTime calculationDay;
            if (year == 2020)
            {
                //https://www.bbc.co.uk/news/uk-48565417
                calculationDay = DateTimeFactory.FindDay(year, 5, DayOfWeek.Friday, 2);
            }
            else
            {
                calculationDay = DateTimeFactory.OffsetByWeek(year, 5, 2, DayOfWeek.Monday);
            }

            return DailyAnswerBuilder
                .Create(Name)
                .From(calculationDay)
                .Country(Country.ToCode(), GetRegionCodeList())
                .I18N(I18NIdentityCode)
                .Build(year);
        }
    }
}