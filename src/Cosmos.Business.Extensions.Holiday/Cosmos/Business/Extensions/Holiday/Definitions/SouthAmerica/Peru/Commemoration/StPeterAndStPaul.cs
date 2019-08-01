using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Peru.Commemoration
{
    /// <summary>
    /// St. Peter and St. Paul
    /// </summary>
    public class StPeterAndStPaul : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Peru;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Peru;

        /// <inheritdoc />
        public override string Name { get; } = "Día de San Pedro y San Pablo";

        /// <inheritdoc />
        public override int Month { get; set; } = 6;

        /// <inheritdoc />
        public override int Day { get; set; } = 29;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_py_peter_and_paul";
    }
}