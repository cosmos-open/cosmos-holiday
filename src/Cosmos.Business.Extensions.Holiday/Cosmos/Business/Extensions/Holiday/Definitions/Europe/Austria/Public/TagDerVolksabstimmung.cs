using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Austria.Public
{
    /// <summary>
    /// Tag der Volksabstimmung
    /// </summary>
    public class TagDerVolksabstimmung : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Austria;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Austria;

        /// <inheritdoc />
        public override string RegionCode { get; } = "AT-2";

        /// <inheritdoc />
        public override string Name { get; } = "Tag der Volksabstimmung";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 19;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_at_tag_der_volksabstimmung";
    }
}