using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Peru.Religion
{
    /// <summary>
    /// Santa Rosa de Lima
    /// </summary>
    public class SantaRosaDeLima : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Peru;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Peru;

        /// <inheritdoc />
        public override string Name { get; } = "Día de Santa Rosa de Lima";

        /// <inheritdoc />
        public override int Month { get; set; } = 8;

        /// <inheritdoc />
        public override int Day { get; set; } = 30;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_py_santa_rosa_de_lima";
    }
}