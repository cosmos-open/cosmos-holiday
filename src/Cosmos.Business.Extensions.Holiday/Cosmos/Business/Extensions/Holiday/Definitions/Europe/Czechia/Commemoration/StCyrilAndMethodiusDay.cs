using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Czechia.Commemoration
{
    /// <summary>
    /// St. Cyril and Methodius Day
    /// </summary>
    public class StCyrilAndMethodiusDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Czechia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Czechia;

        /// <inheritdoc />
        public override string Name { get; } = "Den slovanských věrozvěstů Cyrila a Metoděje";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 7;

        /// <inheritdoc />
        public override int Day { get; set; } = 5;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cz_stcyril_and_methodius";
    }
}