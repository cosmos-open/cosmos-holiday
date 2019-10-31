using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Malawi.Commemoration
{
    /// <summary>
    /// Martyrs' Day
    /// </summary>
    public class MartyrsDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Malawi;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Malawi;

        /// <inheritdoc />
        public override string Name { get; } = "Martyrs' Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; } = 3;

        /// <inheritdoc />
        public override int Day { get; } = 3;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 1;

        /// <inheritdoc />
        protected override int SaturdayShift { get; } = 2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_mw_martyr";
    }
}