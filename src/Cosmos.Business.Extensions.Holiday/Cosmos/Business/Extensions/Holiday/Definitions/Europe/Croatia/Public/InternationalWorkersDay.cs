using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Croatia.Public
{
    /// <summary>
    /// International Workers' Day
    /// </summary>
    public class InternationalWorkersDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Croatia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Croatia;

        /// <inheritdoc />
        public override string Name { get; } = "Međunarodni praznik rada";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_hr_workers";
    }
}