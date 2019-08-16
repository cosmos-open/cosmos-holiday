using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Netherlands.Public
{
    /// <summary>
    /// King's Day
    /// </summary>
    public class KingsDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Netherlands;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Netherlands;

        /// <inheritdoc />
        public override string Name { get; } = "Koningsdag";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; } = 4;

        /// <inheritdoc />
        public override int Day { get; } = 27;

        /// <inheritdoc />
        protected override int SaturdayShift { get; } = 0;

        /// <inheritdoc />
        protected override int SundayShift { get; } = -1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_nl_king";
    }
}