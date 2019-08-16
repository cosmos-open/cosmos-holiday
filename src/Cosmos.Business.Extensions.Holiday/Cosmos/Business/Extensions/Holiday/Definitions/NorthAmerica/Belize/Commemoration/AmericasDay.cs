using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Belize.Commemoration
{
    /// <summary>
    /// Day of the Americas
    /// </summary>
    public class AmericasDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Belize;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Belize;

        /// <inheritdoc />
        public override string Name { get; } = "Day of the Americas";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; } = 10;

        /// <inheritdoc />
        public override int Day { get; } = 12;

        /// <inheritdoc />
        protected override int TuesdayShift { get; } = -1;

        /// <inheritdoc />
        protected override int WednesdayShift { get; } = -2;

        /// <inheritdoc />
        protected override int ThursdayShift { get; } = -3;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bz_americas";
    }
}