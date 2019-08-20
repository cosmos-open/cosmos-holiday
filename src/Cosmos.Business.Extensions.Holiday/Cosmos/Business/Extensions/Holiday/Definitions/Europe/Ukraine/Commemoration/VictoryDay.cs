using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Ukraine.Commemoration
{
    /// <summary>
    /// Victory day over Nazism in World War II
    /// </summary>
    public class VictoryDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Ukraine;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Ukraine;

        /// <inheritdoc />
        public override string Name { get; } = "День перемоги над нацизмом у Другій світовій війні";

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 9;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ua_victory";
    }
}