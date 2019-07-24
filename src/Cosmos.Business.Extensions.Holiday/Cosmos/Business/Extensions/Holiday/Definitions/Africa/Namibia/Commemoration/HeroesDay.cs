using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Namibia.Commemoration
{
    /// <summary>
    /// Heroes' Day
    /// </summary>
    public class HeroesDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Namibia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Namibia;

        /// <inheritdoc />
        public override string Name { get; } = "Heroes' Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 8;

        /// <inheritdoc />
        public override int Day { get; set; } = 26;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_na_heroes";
    }
}