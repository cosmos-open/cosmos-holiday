using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.SouthKorea.Public
{
    /// <summary>
    /// Liberation Day<br />
    /// ko: 광복절
    /// </summary>
    public class LiberationDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.SouthKorea;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.SouthKorea;

        /// <inheritdoc />
        public override string Name { get; } = "광복절";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 8;

        /// <inheritdoc />
        public override int Day { get; set; } = 15;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_kr_liberation";
    }
}