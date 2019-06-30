using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Oceania.Australia.Public
{
    /// <summary>
    /// Family and community day, Australian Capital Territory.
    /// </summary>
    public class FamilyAndCommunityDay : BaseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Australia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Australia;

        /// <inheritdoc />
        public override string RegionCode { get; } = "AU-ACT";

        /// <inheritdoc />
        public override string Name { get; } = "Family and community day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_au_family_community";

        /// <inheritdoc />
        public override int? Since { get; } = 2007;

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            DateTime calculationDay;

            if (year >= 2007 && year <= 2009)
            {
                calculationDay = DateTimeFactory.FindNextDay(year, 11, 1, DayOfWeek.Tuesday);
            }
            else
            {
                //2010+ first Monday of the September/October school holidays
                //if coincides with Labour day, moves to 2nd Monday
                var facDay = DateTimeFactory.FindNextDay(year, 9, 25, DayOfWeek.Monday);
                if (facDay == DateTimeFactory.FindNextDay(year, 10, 1, DayOfWeek.Monday))
                    facDay = facDay.AddDays(7);
                calculationDay = facDay;
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