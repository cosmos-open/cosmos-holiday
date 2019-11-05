using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.SouthSudan.Public
{
    /// <summary>
    /// SPLA Day
    /// </summary>
    public class SplaDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.SouthSudan;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.SouthSudan;

        /// <inheritdoc />
        public override string Name { get; } = "SPLA Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 16;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ss_spla";
    }
}