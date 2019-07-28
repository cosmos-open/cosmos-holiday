using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Barbados.Public
{
    /// <summary>
    /// National Heroes' Day
    /// </summary>
    public class NationalHeroesDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Barbados;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Barbados;

        /// <inheritdoc />
        public override string Name { get; } = "National Heroes' Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 4;

        /// <inheritdoc />
        public override int Day { get; set; } = 28;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bb_national_heroes";
    }
}