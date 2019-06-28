using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Extensions;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Japan.Public
{
    /// <summary>
    /// Labour Thanksgiving Day
    /// </summary>
    public class LabourThanksgivingDay : BaseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Japan;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Japan;

        /// <inheritdoc />
        public override string Name { get; } = "勤労感謝の日";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_jp_labour_thanksgiving";

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            var calculationDay = DateTimeFactory
                .Create(year, 11, 23)
                .Shift(saturday => saturday, sunday => sunday.AddDays(1));
            return DailyAnswerBuilder
                .Create(Name)
                .From(calculationDay)
                .Country(Country.ToCode(), GetRegionCodeList())
                .I18N(I18NIdentityCode)
                .Build(year);
        }
    }
}