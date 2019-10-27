using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Philippines.Commemoration
{
    /// <summary>
    /// Feast of the Immaculate Conception of the Blessed Virgin Mary<br />
    /// fil: Pagdiriwang ng Kalinis-linisang Paglilihi sa Mahal na Birheng Maria
    /// </summary>
    public class Mary : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Philippines;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Philippines;

        /// <inheritdoc />
        public override string Name { get; } = "Feast of the Immaculate Conception of the Blessed Virgin Mary";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 8;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ph_mary";
    }
}