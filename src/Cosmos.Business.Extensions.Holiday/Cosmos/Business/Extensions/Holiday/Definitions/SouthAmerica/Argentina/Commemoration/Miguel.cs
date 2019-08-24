using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Argentina.Commemoration
{
    /// <summary>
    /// Anniversary of the Passing of General Martín Miguel de Güemes
    /// </summary>
    public class Miguel : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Argentina;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Argentina;

        /// <inheritdoc />
        public override string Name { get; } = "Paso a la Inmortalidad del General Martín Miguel de Güemes";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 6;

        /// <inheritdoc />
        public override int Day { get; set; } = 17;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ar_miguel";
    }
}