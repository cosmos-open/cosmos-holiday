using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Bonaire.Religion
{
    /// <summary>
    /// Carnival<br />
    /// nl: Carnavalmaandag
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class Carnival48_sa : WeekOffsetVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bonaire;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Netherlands;

        /// <inheritdoc />
        public override string RegionCode { get; } = "BQ-SA";

        /// <inheritdoc />
        public override string Name { get; } = "Carnavalmaandag";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; } = 8;

        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 1;

        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Monday;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bq_carnival48_sa";
    }
}