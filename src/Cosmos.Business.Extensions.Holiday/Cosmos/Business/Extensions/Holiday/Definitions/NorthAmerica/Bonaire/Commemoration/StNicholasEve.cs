using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Bonaire.Commemoration
{
    /// <summary>
    /// St. Nicholas' Eve<br />
    /// nl: Sinterklaasavond
    /// </summary>
    public class StNicholasEve : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bonaire;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Netherlands;

        /// <inheritdoc />
        public override string Name { get; } = "Sinterklaasavond";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 5;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bq_nicholas";
    }
}