using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Paraguay.Commemoration
{
    /// <summary>
    /// Heroes' day
    /// </summary>
    public class Heroesday : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Paraguay;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Paraguay;

        /// <inheritdoc />
        public override string Name { get; } = "Dia de los héroes";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_py_heroes";
    }
}