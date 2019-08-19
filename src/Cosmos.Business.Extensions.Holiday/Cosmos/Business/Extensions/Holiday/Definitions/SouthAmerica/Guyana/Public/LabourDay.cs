using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Guyana.Public
{
    /// <summary>
    /// Labour Day
    /// </summary>
    public class LabourDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Guyana;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Guyana;

        /// <inheritdoc />
        public override string Name { get; } = "Labour Day";

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gy_labour";
    }
}