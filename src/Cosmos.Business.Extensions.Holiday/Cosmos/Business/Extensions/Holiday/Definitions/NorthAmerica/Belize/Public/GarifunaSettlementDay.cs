using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Belize.Public
{
    /// <summary>
    /// Garifuna Settlement Day
    /// </summary>
    public class GarifunaSettlementDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Belize;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Belize;

        /// <inheritdoc />
        public override string Name { get; } = "Garifuna Settlement Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; } = 11;

        /// <inheritdoc />
        public override int Day { get; } = 19;

        /// <inheritdoc />
        protected override int SaturdayShift { get; } = 2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bz_garifuna_settlement";
    }
}