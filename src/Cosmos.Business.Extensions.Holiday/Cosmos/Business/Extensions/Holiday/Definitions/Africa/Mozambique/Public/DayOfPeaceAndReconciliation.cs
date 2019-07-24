using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Mozambique.Public
{
    /// <summary>
    /// Day of Peace and Reconciliation
    /// </summary>
    public class DayOfPeaceAndReconciliation : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Mozambique;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Mozambique;

        /// <inheritdoc />
        public override string Name { get; } = "Dia da Paz e da Reconcialição";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 4;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_mz_peace_and_reconciliation";
    }
}