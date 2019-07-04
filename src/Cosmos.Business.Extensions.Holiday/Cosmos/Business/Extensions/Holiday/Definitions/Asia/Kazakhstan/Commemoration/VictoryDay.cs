using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Kazakhstan.Commemoration
{
    /// <summary>
    /// Victory Day - Mai 9st
    /// </summary>
    public class VictoryDay: BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Kazakhstan;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Kazakhstan;

        /// <inheritdoc />
        public override string Name { get; } = "День Победы";

        /// <summary>
        /// Type of holiday
        /// </summary>
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 9;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_kz_victory_day";
    }
}