using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Mozambique.Commemoration
{
    /// <summary>
    /// Heroes' Day
    /// </summary>
    public class HeroesDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Mozambique;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Mozambique;

        /// <inheritdoc />
        public override string Name { get; } = "Dia do Heroi Nacional";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 2;

        /// <inheritdoc />
        public override int Day { get; set; } = 3;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_mz_heroes";
    }
}