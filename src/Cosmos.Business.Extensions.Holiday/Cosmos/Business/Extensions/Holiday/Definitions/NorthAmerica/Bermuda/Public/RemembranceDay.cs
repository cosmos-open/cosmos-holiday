using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Bermuda.Public
{
    /// <summary>
    /// Remembrance Day
    /// </summary>
    public class RemembranceDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bermuda;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.UnitedKingdom;

        /// <inheritdoc />
        public override string Name { get; } = "Remembrance Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; } = 11;

        /// <inheritdoc />
        public override int Day { get; } = 11;

        /// <inheritdoc />
        protected override int SaturdayShift { get; } = 2;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bm_remembrance";
    }
}