using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Estonia.Commemoration
{
    /// <summary>
    /// Grandparents Day<br />
    /// et:vanavanemate päev
    /// </summary>
    public class GrandparentsDay : WeekOffsetVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Estonia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Estonia;

        /// <inheritdoc />
        public override string Name { get; } = "vanavanemate päev";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; } = 9;

        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 2;

        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Sunday;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ee_grandparents";
    }
}