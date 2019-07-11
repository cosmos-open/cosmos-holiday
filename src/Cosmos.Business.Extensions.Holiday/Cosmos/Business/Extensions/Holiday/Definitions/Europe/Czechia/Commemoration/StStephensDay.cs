using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Czechia.Commemoration
{
    /// <summary>
    /// Druhý svátek vánoční - St. Stephen's Day - 2nd day of Christmas
    /// Literally, Second Christmas Holiday
    /// in the older law it was named as "Hod Boží vánoční"
    /// </summary>
    public class StStephensDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Czechia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Czechia;

        /// <summary>
        /// Stefanitag
        /// </summary>
        public override string Name { get; } = "Druhý svátek vánoční";

        /// <summary>
        /// Type of holiday
        /// </summary>
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 26;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cz_ststephensday";
    }
}