using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Oceania.AmericanSamoa.Religion
{
    /// <summary>
    /// Thanksgiving Day
    /// </summary>
    public class ThanksgivingDay : WeekOffsetVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.AmericanSamoa;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.UnitedStates;

        /// <inheritdoc />
        public override string Name { get; } = "Thanksgiving Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; } = 11;

        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 4;

        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Thursday;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_as_thanks_giving";

        /// <inheritdoc />
        public override int? Since { get; } = 1863;

    }
}