using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Slovenia.Public
{
    /// <summary>
    /// May Day Holiday
    /// </summary>
    public class MayDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Slovenia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Slovenia;

        /// <inheritdoc />
        public override string Name { get; } = "praznik dela";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override (int Month, int Day)? FromDate { get; set; } = (5, 1);

        /// <inheritdoc />
        public override (int Month, int Day)? ToDate { get; set; } = (5, 2);

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_si_may_day";
    }
}