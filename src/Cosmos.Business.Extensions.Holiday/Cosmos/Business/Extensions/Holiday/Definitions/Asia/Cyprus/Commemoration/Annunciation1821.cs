using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Cyprus.Commemoration
{
    /// <summary>
    /// Annunciation, Anniversary of 1821 Revolution
    /// </summary>
    public class Annunciation1821 : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Cyprus;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Cyprus;

        /// <inheritdoc />
        public override string Name { get; } = "Annunciation, Anniversary of 1821 Revolution";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 25;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cy_annunciation_1821";
    }
}