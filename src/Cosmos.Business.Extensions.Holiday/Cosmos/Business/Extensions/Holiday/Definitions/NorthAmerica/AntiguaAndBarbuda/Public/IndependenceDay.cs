using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.AntiguaAndBarbuda.Public
{
    /// <summary>
    /// Independence Day
    /// </summary>
    public class IndependenceDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.AntiguaAndBarbuda;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.AntiguaAndBarbuda;

        /// <inheritdoc />
        public override string Name { get; } = "Independence Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; } = 11;

        /// <inheritdoc />
        public override int Day { get; } = 1;

        /// <inheritdoc />
        protected override int SaturdayShift { get; } = 2;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ag_independence";
    }
}