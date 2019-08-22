using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Oceania.NewZealand.Public
{
    /// <summary>
    /// Anzac Day
    /// </summary>
    public class AnzacDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.NewZealand;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.NewZealand;

        /// <inheritdoc />
        public override string Name { get; } = "Anzac Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; } = 4;

        /// <inheritdoc />
        public override int Day { get; } = 25;

        /// <inheritdoc />
        protected override int SaturdayShift { get; } = 2;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_nz_anzac";

        /// <inheritdoc />
        public override int? Since { get; } = 2015;
    }
}