using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Cuba.Commemoration
{
    /// <summary>
    /// Victory of Fidel Castr
    /// </summary>
    public class VictoryOfFidelCastro : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Cuba;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Cuba;

        /// <inheritdoc />
        public override string Name { get; } = "Día de Victoria de las Fuerzas Armadas";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cu_cictory_of_fidel_castro";
    }
}