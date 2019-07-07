using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Russia.Public
{
    /// <summary>
    /// Russia Day
    /// </summary>
    public class RussiaDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Russia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Russia;

        /// <inheritdoc />
        public override string Name { get; } = "День России";

        /// <inheritdoc />
        public override int Month { get; set; } = 6;

        /// <inheritdoc />
        public override int Day { get; set; } = 12;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ru_russia_day";
    }
}