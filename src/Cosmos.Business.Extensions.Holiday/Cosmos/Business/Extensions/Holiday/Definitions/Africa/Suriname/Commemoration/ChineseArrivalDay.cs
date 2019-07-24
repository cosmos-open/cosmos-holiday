using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Suriname.Commemoration
{
    /// <summary>
    /// Chinese Arrival day
    /// </summary>
    public class ChineseArrivalDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Suriname;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Suriname;

        /// <inheritdoc />
        public override string Name { get; } = "Chinese Arrival Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 20;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_sr_chinese_arrival";
    }
}