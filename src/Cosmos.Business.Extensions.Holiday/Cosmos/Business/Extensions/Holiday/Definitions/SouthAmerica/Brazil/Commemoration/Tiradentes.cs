using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Brazil.Commemoration
{
    /// <summary>
    /// Tiradentes
    /// </summary>
    public class Tiradentes : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Brazil;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Brazil;

        /// <inheritdoc />
        public override string Name { get; } = "Dia de Tiradentes";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 4;

        /// <inheritdoc />
        public override int Day { get; set; } = 21;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_br_tiradentes";
    }
}