using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Zambia.Religion
{
    /// <summary>
    /// Christmas Day
    /// </summary>
    public class ChristmasDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Zambia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Zambia;

        /// <inheritdoc />
        public override string Name { get; } = "Christmas Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;
        
        /// <inheritdoc />
        public override int Month { get; } = 12;

        /// <inheritdoc />
        public override int Day { get; } = 25;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_zm_christmas";
    }
}