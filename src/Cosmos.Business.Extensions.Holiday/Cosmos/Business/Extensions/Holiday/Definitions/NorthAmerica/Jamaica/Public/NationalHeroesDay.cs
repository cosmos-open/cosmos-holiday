using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Jamaica.Public
{
    /// <summary>
    /// National Heroes Day
    /// </summary>
    public class NationalHeroesDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Jamaica;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Jamaica;

        /// <inheritdoc />
        public override string Name { get; } = "National Heroes Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 16;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_jm_national_heroes";
    }
}