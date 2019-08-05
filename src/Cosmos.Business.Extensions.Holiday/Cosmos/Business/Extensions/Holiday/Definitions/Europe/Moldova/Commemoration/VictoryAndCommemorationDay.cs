using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Moldova.Commemoration
{
    /// <summary>
    /// Victory and Commemoration Day
    /// </summary>
    public class VictoryAndCommemorationDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Moldova;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Moldova;

        /// <inheritdoc />
        public override string Name { get; } = "Victory and Commemoration Day";

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 9;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_md_victory_and_commemoration";
    }
}