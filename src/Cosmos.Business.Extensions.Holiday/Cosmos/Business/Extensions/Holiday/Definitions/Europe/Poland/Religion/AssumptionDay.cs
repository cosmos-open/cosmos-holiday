using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Poland.Religion
{
    /// <summary>
    /// Assumption Day
    /// </summary>
    public class AssumptionDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Poland;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Poland;

        /// <inheritdoc />
        public override string Name { get; } = "Wniebowzięcie Najświętszej Maryi Panny";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 8;

        /// <inheritdoc />
        public override int Day { get; set; } = 15;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_pl_assumption_day";
    }
}