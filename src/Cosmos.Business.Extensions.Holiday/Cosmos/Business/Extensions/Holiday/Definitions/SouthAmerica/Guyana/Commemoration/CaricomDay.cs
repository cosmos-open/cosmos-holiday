using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Guyana.Commemoration
{
    /// <summary>
    /// Caricom Day
    /// </summary>
    public class CaricomDay : WeekOffsetVariableHolidayFunc
    {

        /// <inheritdoc />
        public override Country Country { get; } = Country.Guyana;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Guyana;

        /// <inheritdoc />
        public override string Name { get; } = "Caricom Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gy_caricom";

        /// <inheritdoc />
        public override int Month { get; } = 7;

        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 1;

        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Monday;
    }
}