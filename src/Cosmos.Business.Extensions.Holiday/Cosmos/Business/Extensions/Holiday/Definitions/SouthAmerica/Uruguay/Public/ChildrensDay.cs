using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Uruguay.Public
{
    /// <summary>
    /// Children's Day
    /// </summary>
    public class ChildrensDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Uruguay;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Uruguay;

        /// <inheritdoc />
        public override string Name { get; } = "Día de los Niños";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 6;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_uy_children";
    }
}