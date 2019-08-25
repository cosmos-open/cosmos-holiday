using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Bolivia.Commemoration
{
    /// <summary>
    /// Agrarian Reform Day
    /// </summary>
    public class AgrarianReformDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bolivia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Bolivia;

        /// <inheritdoc />
        public override string Name { get; } = "Día de la Revolución Agraria";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 8;

        /// <inheritdoc />
        public override int Day { get; set; } = 2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bo_agrarian_reform";
    }
}