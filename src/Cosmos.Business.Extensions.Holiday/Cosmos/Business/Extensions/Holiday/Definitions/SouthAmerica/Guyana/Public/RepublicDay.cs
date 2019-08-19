using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Guyana.Public
{
    /// <summary>
    /// Republic Day
    /// </summary>
    public class RepublicDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Guyana;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Guyana;

        /// <inheritdoc />
        public override string Name { get; } = "Republic Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 2;

        /// <inheritdoc />
        public override int Day { get; set; } = 23;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gy_republic";
    }
}