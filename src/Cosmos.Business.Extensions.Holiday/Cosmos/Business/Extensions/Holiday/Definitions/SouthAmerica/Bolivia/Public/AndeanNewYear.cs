using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Bolivia.Public
{
    /// <summary>
    /// Andean New Year
    /// </summary>
    public class AndeanNewYear : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bolivia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Bolivia;

        /// <inheritdoc />
        public override string Name { get; } = "Año Nuevo Andino";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 6;

        /// <inheritdoc />
        public override int Day { get; set; } = 21;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bo_andean_new_year";
    }
}