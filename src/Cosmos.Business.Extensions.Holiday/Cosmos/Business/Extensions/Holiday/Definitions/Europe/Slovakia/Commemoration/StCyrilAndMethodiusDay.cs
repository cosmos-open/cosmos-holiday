using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Slovakia.Commemoration
{
    /// <summary>
    /// St. Cyril and Methodius Day
    /// </summary>
    public class StCyrilAndMethodiusDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Slovakia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Slovakia;

        /// <inheritdoc />
        public override string Name { get; } = "Sviatok svätého Cyrila a Metoda";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 7;

        /// <inheritdoc />
        public override int Day { get; set; } = 5;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_sk_stcyril_and_methodius";
    }
}