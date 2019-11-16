using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Bonaire.Public
{
    /// <summary>
    /// Statia Day
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class StatiaDay_se : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bonaire;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Netherlands;

        /// <inheritdoc />
        public override string RegionCode { get; } = "BQ-SE";

        /// <inheritdoc />
        public override string Name { get; } = "Statia Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 16;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bq_statia_se";
    }
}