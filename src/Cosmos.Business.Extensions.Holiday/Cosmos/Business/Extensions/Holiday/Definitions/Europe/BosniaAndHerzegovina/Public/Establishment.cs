using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.BosniaAndHerzegovina.Public
{
    /// <summary>
    /// Day of the Establishment of the District
    /// </summary>
    public class Establishment : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.BosniaAndHerzegovina;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.BosniaAndHerzegovina;

        /// <inheritdoc />
        public override string RegionCode { get; } = "BA-BRC";

        /// <inheritdoc />
        public override string Name { get; } = "Day of the Establishment of the District";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 8;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ba_establishment";
    }
}