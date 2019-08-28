using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Chile.Commemoration
{
    /// <summary>
    /// Columbus Day
    /// </summary>
    public class ColumbusDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Chile;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Chile;

        /// <inheritdoc />
        public override string Name { get; } = "Día del Descubrimiento de Dos Mundos";

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 9;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cl_columbus";
    }
}