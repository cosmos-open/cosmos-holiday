using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Bonaire.Commemoration
{
    /// <summary>
    /// Fathers' Day<br />
    /// nl: Vaderdag
    /// </summary>
    public class FathersDay : WeekOffsetVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bonaire;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Netherlands;

        /// <inheritdoc />
        public override string Name { get; } = "Vaderdag";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; } = 6;

        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 3;

        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Sunday;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bq_father";
    }
}