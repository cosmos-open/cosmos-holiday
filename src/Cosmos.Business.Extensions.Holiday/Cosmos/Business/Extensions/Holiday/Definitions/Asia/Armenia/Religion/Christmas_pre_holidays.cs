using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Armenia.Religion
{
    /// <summary>
    /// Pre-Christmas Holiday
    /// </summary>
    public class PreChristmasHolidays: BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Armenia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Armenia;

        /// <inheritdoc />
        public override string Name { get; } = "Նախածննդյան տոներ";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override (int Month, int Day)? FromDate { get; set; } = (1, 3);

        /// <inheritdoc />
        public override (int Month, int Day)? ToDate { get; set; } = (1, 5);

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_am_christmas_pre";
    }
}