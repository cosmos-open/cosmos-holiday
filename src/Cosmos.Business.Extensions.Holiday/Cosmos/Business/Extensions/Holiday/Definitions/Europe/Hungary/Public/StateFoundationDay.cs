using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Hungary.Public
{
    /// <summary>
    /// State Foundation Day
    /// </summary>
    public class StateFoundationDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Hungary;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Hungary;

        /// <inheritdoc />
        public override string Name { get; } = "Az államalapítás ünnepe";

        /// <inheritdoc />
        public override int Month { get; set; } = 8;

        /// <inheritdoc />
        public override int Day { get; set; } = 20;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_hu_state_foundation";
    }
}