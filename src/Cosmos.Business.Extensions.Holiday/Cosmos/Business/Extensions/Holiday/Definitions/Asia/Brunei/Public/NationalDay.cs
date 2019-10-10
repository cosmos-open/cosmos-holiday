using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Brunei.Public
{
    /// <summary>
    /// Nation Day<br />
    /// ms: Hari Kebangsaan
    /// </summary>
    public class NationalDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Brunei;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Brunei;

        /// <inheritdoc />
        public override string Name { get; } = "Hari Kebangsaan";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 2;

        /// <inheritdoc />
        public override int Day { get; set; } = 23;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bn_nation";
    }
}