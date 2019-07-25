using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Venezuela.Public
{
    /// <summary>
    /// Slavery Abolition Anniversary
    /// </summary>
    public class SlaveryAbolitionAnniversary : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Venezuela;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Venezuela;

        /// <inheritdoc />
        public override string Name { get; } = "Día del abolición de la esclavitud";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 21;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ve_slavery_abolition_anniversary";
    }
}