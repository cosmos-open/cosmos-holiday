using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Serbia.Public
{
    /// <summary>
    /// May Day / International Workers' Day
    /// </summary>
    public class MayDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Serbia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Serbia;

        /// <inheritdoc />
        public override string Name { get; } = "Praznik rada";

        /// <inheritdoc />
        public override (int Month, int Day)? FromDate { get; set; } = (5, 1);

        /// <inheritdoc />
        public override (int Month, int Day)? ToDate { get; set; } = (5, 2);

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_rs_may_day";
    }
}