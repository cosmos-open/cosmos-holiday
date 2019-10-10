using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Brunei.Public
{
    /// <summary>
    /// Christmas Day<br />
    /// ms: Hari Natal
    /// </summary>
    public class ChristmasDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Brunei;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Brunei;

        /// <inheritdoc />
        public override string Name { get; } = "Hari Natal";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 25;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bn_christmas";
    }
}