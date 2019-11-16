using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Bonaire.Public
{
    /// <summary>
    /// Bonaire Day<br />
    /// nl: Boneiru Dag
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class BonaireDay_bo: BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bonaire;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Netherlands;

        /// <inheritdoc />
        public override string RegionCode { get; } = "BQ-BO";

        /// <inheritdoc />
        public override string Name { get; } = "Boneiru Dag";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 9;

        /// <inheritdoc />
        public override int Day { get; set;} = 6;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bq_bonaire_bo";
    }
}