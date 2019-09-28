using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Bangladesh.Commemoration
{
    /// <summary>
    /// Martyred Intellectuals Day
    /// </summary>
    public class MartyrsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bangladesh;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Bangladesh;

        /// <inheritdoc />
        public override string Name { get; } = "Martyred Intellectuals Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 14;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bd_martyr";
    }
}