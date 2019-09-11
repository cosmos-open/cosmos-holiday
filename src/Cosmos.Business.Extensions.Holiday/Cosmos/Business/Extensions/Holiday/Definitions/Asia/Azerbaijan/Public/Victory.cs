using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Azerbaijan.Public
{
    /// <summary>
    /// Day of Victory over Fascism
    /// </summary>
    public class Victory : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Azerbaijan;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Azerbaijan;

        /// <inheritdoc />
        public override string Name { get; } = "Faşizm üzərində qələbə günü";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; } = 5;

        /// <inheritdoc />
        public override int Day { get; } = 9;

        /// <inheritdoc />
        protected override int SaturdayShift { get; } = 2;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_az_victory";
    }
}