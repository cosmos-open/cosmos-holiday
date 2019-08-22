using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Oceania.NewZealand.Religion
{
    /// <summary>
    /// Boxing Day
    /// </summary>
    public class BoxingDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.NewZealand;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.NewZealand;

        /// <inheritdoc />
        public override string Name { get; } = "Boxing Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; } = 12;

        /// <inheritdoc />
        public override int Day { get; } = 26;

        /// <inheritdoc />
        protected override int SaturdayShift { get; } = 2;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_nz_boxing";
    }
}