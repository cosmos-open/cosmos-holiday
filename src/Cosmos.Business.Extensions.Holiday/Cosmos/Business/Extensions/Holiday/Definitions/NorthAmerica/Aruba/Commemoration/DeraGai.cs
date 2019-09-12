using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Aruba.Commemoration
{
    /// <summary>
    /// Dera Gai
    /// </summary>
    public class DeraGai : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Aruba;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Aruba;

        /// <inheritdoc />
        public override string Name { get; } = "Dera Gai";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 6;

        /// <inheritdoc />
        public override int Day { get; set; } = 24;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_aw_dera_gai";
    }
}