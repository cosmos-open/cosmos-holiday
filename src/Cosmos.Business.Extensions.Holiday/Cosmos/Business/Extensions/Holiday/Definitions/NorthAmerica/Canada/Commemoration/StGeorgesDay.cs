using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Canada.Commemoration
{
    /// <summary>
    /// Saint George's day (April 23)
    /// </summary>
    public class StGeorgesDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Canada;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Canada;

        /// <inheritdoc />
        public override string RegionCode { get; } = "CA-NL";

        /// <inheritdoc />
        public override string Name { get; } = "Saint George's Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ca_george";

        /// <inheritdoc />
        public override int Month { get; } = 4;

        /// <inheritdoc />
        public override int Day { get; } = 23;

        /// <inheritdoc />
        protected override int SaturdayShift { get; } = 2;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 1;
    }
}