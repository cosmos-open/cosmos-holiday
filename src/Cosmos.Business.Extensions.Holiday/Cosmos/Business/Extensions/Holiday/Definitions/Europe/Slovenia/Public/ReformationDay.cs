using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Slovenia.Public
{
    /// <summary>
    /// Reformation Day
    /// </summary>
    public class ReformationDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Slovenia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Slovenia;

        /// <inheritdoc />
        public override string Name { get; } = "dan reformacije";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 31;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_si_reformation";
    }
}