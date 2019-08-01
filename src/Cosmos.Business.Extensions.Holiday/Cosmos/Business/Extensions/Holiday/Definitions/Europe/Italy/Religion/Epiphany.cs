using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Italy.Religion
{
    /// <summary>
    /// Epiphany
    /// </summary>
    public class Epiphany : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Italy;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Italy;

        /// <inheritdoc />
        public override string Name { get; } = "Epifania";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 6;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_it_epiphany";
    }
}