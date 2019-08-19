using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Guyana.Commemoration
{
    /// <summary>
    /// Arrival Day
    /// </summary>
    public class ArrivalDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Guyana;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Guyana;

        /// <inheritdoc />
        public override string Name { get; } = "Arrival Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 5;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gy_arrival";
    }
}