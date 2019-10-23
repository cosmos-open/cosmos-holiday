using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Czechia.Religion
{
    /// <summary>
    /// Ugly Wednesday<br />
    /// cz: Škaredá středa
    /// </summary>
    public class UglyWednesday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Czechia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Czechia;

        /// <inheritdoc />
        public override string Name { get; } = "Škaredá středa";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -4;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cz_ugly_wednesday";
    }
}