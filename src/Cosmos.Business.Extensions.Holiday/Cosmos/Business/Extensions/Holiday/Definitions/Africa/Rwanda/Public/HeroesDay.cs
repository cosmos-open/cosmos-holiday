using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Rwanda.Public
{
    /// <summary>
    /// Heroes Day
    /// </summary>
    public class HeroesDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Rwanda;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Rwanda;

        /// <inheritdoc />
        public override string Name { get; } = "Heroes Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 2;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_rw_heroes";
    }
}