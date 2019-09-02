using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Colombia.Commemoration
{
    /// <summary>
    /// Saint Peter and Saint Paul
    /// </summary>
    public class SaintPeterAndSaintPaul : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Colombia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Colombia;

        /// <inheritdoc />
        public override string Name { get; } = "San Pedro y San Pablo";

        /// <inheritdoc />
        public override int Month { get; set; } = 6;

        /// <inheritdoc />
        public override int Day { get; set; } = 29;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_co_peter_and_paul";
    }
}