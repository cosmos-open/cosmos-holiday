using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Bonaire.Public
{
    /// <summary>
    /// Kings Day<br />
    /// nl: Koningsdag
    /// </summary>
    public class KingsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bonaire;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Netherlands;

        /// <inheritdoc />
        public override string Name { get; } = "Koningsdag";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 4;

        /// <inheritdoc />
        public override int Day { get; set; } = 27;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bq_king";
    }
}