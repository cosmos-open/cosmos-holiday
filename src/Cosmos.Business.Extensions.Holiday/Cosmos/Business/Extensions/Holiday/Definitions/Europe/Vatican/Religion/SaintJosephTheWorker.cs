using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Vatican.Religion
{
    /// <summary>
    /// Saint Joseph the Worker
    /// </summary>
    public class SaintJosephTheWorker : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Vatican;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Vatican;

        /// <inheritdoc />
        public override string Name { get; } = "San Giuseppe";

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_va_joseph_worker";
    }
}