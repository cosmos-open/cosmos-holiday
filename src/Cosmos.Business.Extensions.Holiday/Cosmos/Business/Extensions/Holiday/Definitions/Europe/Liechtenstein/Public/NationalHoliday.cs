using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Liechtenstein.Public
{
    /// <summary>
    /// National Holiday
    /// </summary>
    public class NationalHoliday : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Liechtenstein;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Liechtenstein;

        /// <inheritdoc />
        public override string Name { get; } = "Staatsfeiertag";

        /// <inheritdoc />
        public override int Month { get; set; } = 8;

        /// <inheritdoc />
        public override int Day { get; set; } = 15;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_li_national_holiday";
    }
}