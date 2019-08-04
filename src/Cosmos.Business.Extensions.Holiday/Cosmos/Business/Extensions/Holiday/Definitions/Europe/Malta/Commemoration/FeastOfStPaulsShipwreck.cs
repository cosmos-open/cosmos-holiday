using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Malta.Commemoration
{
    /// <summary>
    /// Feast of St. Paul's Shipwreck
    /// </summary>
    public class FeastOfStPaulsShipwreck : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Malta;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Malta;

        /// <inheritdoc />
        public override string Name { get; } = "In-Nawfraġju ta’ San Pawl";

        /// <inheritdoc />
        public override int Month { get; set; } = 2;

        /// <inheritdoc />
        public override int Day { get; set; } = 10;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_mt_paul_shipwreck";
    }
}