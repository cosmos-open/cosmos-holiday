using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Romania.Commemoration
{
    /// <summary>
    /// St. Andrew's Day
    /// <br />
    /// 苏格兰国庆日
    /// </summary>
    public class StAndrewsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Romania;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Romania;

        /// <inheritdoc />
        public override string Name { get; } = "Sfântul Andrei";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 30;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ro_andrew";
    }
}