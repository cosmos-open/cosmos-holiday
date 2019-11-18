using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Grenada.Public
{
    /// <summary>
    /// Carnival Monday
    /// </summary>
    public class CarnivalMonday : WeekOffsetVariableHolidayFunc
    {

        /// <inheritdoc />
        public override Country Country { get; } = Country.Grenada;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Grenada;

        /// <inheritdoc />
        public override string Name { get; } = "Carnival Monday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; } = 8;

        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 2;

        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Monday;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gd_carnival_monday";
    }
}