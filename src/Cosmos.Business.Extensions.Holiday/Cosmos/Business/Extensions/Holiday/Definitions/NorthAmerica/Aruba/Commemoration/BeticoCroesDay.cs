using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Aruba.Commemoration
{
    /// <summary>
    /// Betico Croes Day / Herdenking G. F. Croes
    /// </summary>
    public class BeticoCroesDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Aruba;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Aruba;

        /// <inheritdoc />
        public override string Name { get; } = "Dia di Betico";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 25;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_aw_betico_croes";
    }
}