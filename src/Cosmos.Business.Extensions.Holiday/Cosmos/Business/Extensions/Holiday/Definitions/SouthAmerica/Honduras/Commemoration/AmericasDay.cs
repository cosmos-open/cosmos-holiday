using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Honduras.Commemoration
{
    /// <summary>
    /// America's Day
    /// </summary>
    public class AmericasDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Honduras;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Honduras;

        /// <inheritdoc />
        public override string Name { get; } = "America's Day";

        /// <inheritdoc />
        public override int Month { get; set; } = 4;

        /// <inheritdoc />
        public override int Day { get; set; } = 14;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_hn_america";
    }
}