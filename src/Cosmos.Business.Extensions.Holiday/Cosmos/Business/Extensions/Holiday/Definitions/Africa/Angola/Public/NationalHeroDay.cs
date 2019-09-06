using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Angola.Public
{
    /// <summary>
    /// National Hero Day
    /// </summary>
    public class NationalHeroDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Angola;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Angola;

        /// <inheritdoc />
        public override string Name { get; } = "Fundador da Nação e Dia dos Heróis Nacionais";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 9;

        /// <inheritdoc />
        public override int Day { get; set; } = 17;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ao_hero";
    }
}