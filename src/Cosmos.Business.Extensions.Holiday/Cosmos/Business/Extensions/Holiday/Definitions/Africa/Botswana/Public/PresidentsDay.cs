using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Botswana.Public
{
    /// <summary>
    /// Presidents' Day
    /// </summary>
    public class PresidentsDay : WeekOffsetVariableHolidayFunc
    {

        /// <inheritdoc />
        public override Country Country { get; } = Country.Botswana;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Botswana;

        /// <inheritdoc />
        public override string Name { get; } = "residents' Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bw_presidents_day";

        /// <inheritdoc />
        public override int Month { get; } = 7;

        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 3;

        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Monday;
    }
}