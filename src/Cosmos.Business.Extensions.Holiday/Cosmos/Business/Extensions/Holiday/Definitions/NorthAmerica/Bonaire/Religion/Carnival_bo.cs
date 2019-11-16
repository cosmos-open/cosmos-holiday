using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Bonaire.Religion
{
    /// <summary>
    /// Shrove Tuesday
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class Carnival_bo : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bonaire;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Netherlands;

        /// <inheritdoc />
        public override string RegionCode { get; } = "BQ-BO";

        /// <inheritdoc />
        public override string Name { get; } = "Shrove Tuesday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -47;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bq_carnival_bo";
    }
}