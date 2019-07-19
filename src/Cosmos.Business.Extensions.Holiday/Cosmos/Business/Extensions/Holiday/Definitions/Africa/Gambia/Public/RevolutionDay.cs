using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Gambia.Public
{
    /// <summary>
    /// Revolution Day
    /// </summary>
    public class RevolutionDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Gambia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Gambia;

        /// <inheritdoc />
        public override string Name { get; } = "Revolution Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 7;

        /// <inheritdoc />
        public override int Day { get; set; } = 22;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gm_revolution_day";
    }
}