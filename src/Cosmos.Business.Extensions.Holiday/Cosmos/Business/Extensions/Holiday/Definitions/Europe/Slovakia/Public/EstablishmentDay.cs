using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Slovakia.Public
{
    /// <summary>
    /// Day of the Establishment of the Slovak Republic
    /// </summary>
    public class EstablishmentDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Slovakia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Slovakia;

        /// <inheritdoc />
        public override string Name { get; } = "Deň vzniku Slovenskej republiky";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_sk_establishment";
    }
}