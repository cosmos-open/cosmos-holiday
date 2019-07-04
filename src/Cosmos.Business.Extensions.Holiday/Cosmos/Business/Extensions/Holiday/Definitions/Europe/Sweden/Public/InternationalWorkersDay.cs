using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Sweden.Public
{
    /// <summary>
    /// International Workers' Day
    /// </summary>
    public class InternationalWorkersDay: BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Sweden;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Sweden;

        /// <inheritdoc />
        public override string Name { get; } = "Första maj";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_se_international_workers_day";
    }
}