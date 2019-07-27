using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.UnitedKingdom.Religion
{
    /// <summary>
    /// Christmas Day
    /// </summary>
    public class ChristmasDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.UnitedKingdom;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.UnitedKingdom;

        /// <inheritdoc />
        public override string Name { get; } = "Christmas Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; } = 12;

        /// <inheritdoc />
        public override int Day { get; } = 25;

        /// <inheritdoc />
        protected override int SaturdayShift { get; } = 3;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gb_christmas";
    }
}