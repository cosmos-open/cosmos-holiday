using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Mexico.Commemoration
{
    /// <summary>
    /// Constitution Day
    /// </summary>
    public class ConstitutionDay : WeekOffsetVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Mexico;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Mexico;

        /// <inheritdoc />
        public override string Name { get; } = "Día de la Constitución";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; } = 2;

        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 1;

        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Monday;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_mx_constitution";
    }
}