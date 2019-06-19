using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Extensions;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.UnitedStates.Public
{
    public class VeteransDay : BaseVariableHolidayFunc
    {
        public override Country Country { get; } = Country.UnitedStates;

        public override Country BelongsToCountry { get; } = Country.UnitedStates;
        
        public override string Name { get; } = "Veterans Day";

        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        public override string I18NIdentityCode { get; } = "i18n_holiday_us_veteransday";

        public override int? Since { get; } = 1918;

        public override DailyAnswer ToDailyAnswer(int year)
        {
            var calculationDay = DateTimeFactory
                .Create(year, 11, 11)
                .Shift(saturday => saturday.AddDays(-1), sunday => sunday.AddDays(1));
            return DailyAnswerBuilder.Create(Name).From(calculationDay).I18N(I18NIdentityCode).Build(year);
        }
    }
}