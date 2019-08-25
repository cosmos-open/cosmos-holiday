using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Bolivia.Commemoration
{
    /// <summary>
    /// Feast of the Virgin of Candelaria
    /// </summary>
    public class FeastOfTheVirginOfCandelaria : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bolivia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Bolivia;

        /// <inheritdoc />
        public override string Name { get; } = "Fiesta de la Virgen de Candelaria";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 2;

        /// <inheritdoc />
        public override int Day { get; set; } = 3;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bo_feast_virgin";
    }
}