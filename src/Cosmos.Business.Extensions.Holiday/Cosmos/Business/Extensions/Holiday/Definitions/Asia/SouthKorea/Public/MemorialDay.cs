using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.SouthKorea.Public
{
    /// <summary>
    /// Memorial Day<br />
    /// ko: 현충일
    /// </summary>
    public class MemorialDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.SouthKorea;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.SouthKorea;

        /// <inheritdoc />
        public override string Name { get; } = "현충일";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 6;

        /// <inheritdoc />
        public override int Day { get; set; } = 6;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_kr_memorial";
    }
}