using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Japan.Commemoration
{
    /// <summary>
    /// 七五三
    /// </summary>
    public class SevenFiveThreeFestival: BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Japan;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Japan;

        /// <inheritdoc />
        public override string Name { get; } = "七五三";

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 15;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_jp_753";
    }
}