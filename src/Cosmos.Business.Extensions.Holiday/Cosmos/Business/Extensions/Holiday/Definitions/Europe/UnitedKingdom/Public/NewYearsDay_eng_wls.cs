using System;
using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Weekends;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.UnitedKingdom.Public
{
    /// <summary>
    /// New Year's Day for GB-ENG and GB-WLS
    /// </summary>
    public class NewYearsDayEngWls : BaseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.UnitedKingdom;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.UnitedKingdom;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string> {"GB-ENG", "GB-WLS"};

        /// <inheritdoc />
        public override string Name { get; } = "New Year's Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gb_new_year_eng_wls";

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            var calculationDay = DateTimeFactory.Create(year, 1, 1);

            //当元旦为周末时，使用 Region 定义器来定义
            if (WeekendManager.GetWeekendDictionary(CountryCode.GB).IsWeekend(calculationDay))
            {
                calculationDay = DateTimeFactory.FindNextDay(year, 1, 1, DayOfWeek.Monday);
                return DailyAnswerBuilder
                    .Create(Name, HolidayType)
                    .From(calculationDay)
                    .Country(Country.ToCode(), GetRegionCodeList())
                    .I18N(I18NIdentityCode)
                    .Build(year);
            }

            return null;
        }
    }
}