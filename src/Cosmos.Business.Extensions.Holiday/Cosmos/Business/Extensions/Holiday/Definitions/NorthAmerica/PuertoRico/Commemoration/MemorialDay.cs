using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.PuertoRico.Commemoration
{
    /// <summary>
    /// Memorial Day
    /// </summary>
    public class MemorialDay : BaseVariableHolidayFunc
    {

        /// <inheritdoc />
        public override Country Country { get; } = Country.PuertoRico;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.UnitedStates;

        /// <inheritdoc />
        public override string Name { get; } = "Recordación de los Muertos de la Guerra";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_pr_memorial";

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            return DailyAnswerBuilder.Create(Name, HolidayType)
                .From(DateTimeFactory.FindLastDay(year, 5, DayOfWeek.Monday))
                .I18N(I18NIdentityCode)
                .Country(Country.ToCode(), GetRegionCodeList())
                .Build(year);
        }
    }
}