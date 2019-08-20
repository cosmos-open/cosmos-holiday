using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Ukraine.Commemoration
{
    /// <summary>
    /// Defender of Ukraine Day
    /// </summary>
    public class DefenderOfUkraineDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Ukraine;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Ukraine;

        /// <inheritdoc />
        public override string Name { get; } = "День захисника України";

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 14;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ua_defender_ukraine";
    }
}