using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.SouthKorea.Public
{
    /// <summary>
    /// Independence Movement Day<br />
    /// ko: 3·1절
    /// </summary>
    public class IndependenceMovementDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.SouthKorea;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.SouthKorea;

        /// <inheritdoc />
        public override string Name { get; } = "3·1절";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_kr_31";
    }
}