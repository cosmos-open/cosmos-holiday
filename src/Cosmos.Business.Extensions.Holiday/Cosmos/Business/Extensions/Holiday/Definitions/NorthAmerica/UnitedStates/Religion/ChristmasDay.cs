using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Extensions;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.UnitedStates.Religion
{
    public class ChristmasDay : BaseVariableHolidayFunc
    {
        public override Country Country { get; } = Country.UnitedStates;

        public override Country BelongsToCountry { get; } = Country.UnitedStates;

        public override string Name { get; } = "Christmas Day";

        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        public override string I18NIdentityCode { get; } = "i18n_holiday_us_christmasday";

        public override DailyAnswer ToDailyAnswer(int year)
        {
            var calculationDay = DateTimeFactory
                .Create(year, 12, 25)
                .Shift(saturday => saturday.AddDays(-1), sunday => sunday.AddDays(1));
            return DailyAnswerBuilder.Create(Name)
                .From(calculationDay)
                .Country(Country.ToCode(), GetRegionCodeList())
                .I18N(I18NIdentityCode)
                .Build(year);
        }
    }
}