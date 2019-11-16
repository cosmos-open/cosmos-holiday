using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Oceania.Tonga.Public
{
    /// <summary>
    /// Emancipation Day
    /// </summary>
    public class EmancipationDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Tonga;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Tonga;

        /// <inheritdoc />
        public override string Name { get; } = "Emancipation Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; } = 6;

        /// <inheritdoc />
        public override int Day { get; } = 4;

        /// <inheritdoc />
        protected override int TuesdayShift { get; } = -1;

        /// <inheritdoc />
        protected override int ThursdayShift { get; } = 4;

        /// <inheritdoc />
        protected override int FridayShift { get; } = 3;

        /// <inheritdoc />
        protected override int SaturdayShift { get; } = 2;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_to_emancipation";
    }
}