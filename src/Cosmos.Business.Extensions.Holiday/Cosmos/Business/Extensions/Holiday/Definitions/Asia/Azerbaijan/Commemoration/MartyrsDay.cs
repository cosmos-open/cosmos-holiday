using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Azerbaijan.Commemoration
{
    /// <summary>
    /// Martyr's Day
    /// </summary>
    public class MartyrsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Azerbaijan;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Azerbaijan;

        /// <inheritdoc />
        public override string Name { get; } = "Qara Yanvar";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 20;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_az_martyr";
    }
}