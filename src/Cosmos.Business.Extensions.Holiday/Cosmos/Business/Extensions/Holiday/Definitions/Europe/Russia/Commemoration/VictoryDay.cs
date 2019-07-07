using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Russia.Commemoration
{
    /// <summary>
    /// Victory Day
    /// </summary>
    public class VictoryDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Russia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Russia;

        /// <inheritdoc />
        public override string Name { get; } = "День Победы";

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 9;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ru_victory_day";
    }
}