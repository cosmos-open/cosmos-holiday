using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Latvia.Commemoration
{
    /// <summary>
    /// Mother's day
    /// </summary>
    public class MothersDay : WeekOffsetVariableHolidayFunc
    {

        /// <inheritdoc />
        public override Country Country { get; } = Country.Latvia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Latvia;

        /// <inheritdoc />
        public override string Name { get; } = "Mātes diena";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; } = 5;

        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 2;

        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Sunday;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_lv_mother";
    }
}