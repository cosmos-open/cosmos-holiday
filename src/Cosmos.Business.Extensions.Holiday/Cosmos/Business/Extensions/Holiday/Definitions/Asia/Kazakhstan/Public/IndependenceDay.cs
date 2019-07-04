using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Kazakhstan.Public
{
    /// <summary>
    /// Independence day - December 16th
    /// </summary>
    public class IndependenceDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Kazakhstan;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Kazakhstan;

        /// <inheritdoc />
        public override string Name { get; } = "День Независимости Казахстана";

        /// <summary>
        /// Type of holiday
        /// </summary>
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override (int Month, int Day)? FromDate { get; set; } = (12, 16);

        /// <inheritdoc />
        public override (int Month, int Day)? ToDate { get; set; } = (12, 16);

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_kz_independence_day";
    }
}