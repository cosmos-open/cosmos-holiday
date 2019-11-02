using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.ChristmasIsland.Public
{
    /// <summary>
    /// Australia Day
    /// </summary>
    public class AustraliaDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.ChristmasIsland;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Australia;

        /// <inheritdoc />
        public override string Name { get; } = "Australia Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; } = 1;

        /// <inheritdoc />
        public override int Day { get; } = 26;

        /// <inheritdoc />
        protected override int SaturdayShift { get; } = 2;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cx_australia";
    }
}