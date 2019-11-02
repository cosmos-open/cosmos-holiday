using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Rwanda.Public
{
    /// <summary>
    /// National Harvest Day
    /// </summary>
    public class NationalHarvestDay : WeekOffsetVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Rwanda;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Rwanda;

        /// <inheritdoc />
        public override string Name { get; } = "National Harvest Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; } = 8;

        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 1;

        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Friday;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_rw_national_harvest";


    }
}