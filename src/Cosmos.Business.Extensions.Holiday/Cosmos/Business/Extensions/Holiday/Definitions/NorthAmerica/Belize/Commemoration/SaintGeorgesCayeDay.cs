using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Belize.Commemoration
{
    /// <summary>
    /// Saint George's Caye Day
    /// </summary>
    public class SaintGeorgesCayeDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Belize;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Belize;

        /// <inheritdoc />
        public override string Name { get; } = "Saint George's Caye Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; } = 9;

        /// <inheritdoc />
        public override int Day { get; } = 10;

        /// <inheritdoc />
        protected override int SaturdayShift { get; } = 2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bz_georges_caye";
    }
}