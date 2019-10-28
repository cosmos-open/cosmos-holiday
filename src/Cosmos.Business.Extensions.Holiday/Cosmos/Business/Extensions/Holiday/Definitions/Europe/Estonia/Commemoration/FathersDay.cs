using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Estonia.Commemoration
{
    /// <summary>
    /// Fathers Day<br />
    /// et: isadepäev
    /// </summary>
    public class FathersDay : WeekOffsetVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Estonia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Estonia;

        /// <inheritdoc />
        public override string Name { get; } = "isadepäev";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; } = 11;

        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 2;

        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Sunday;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ee_fathers";
    }
}