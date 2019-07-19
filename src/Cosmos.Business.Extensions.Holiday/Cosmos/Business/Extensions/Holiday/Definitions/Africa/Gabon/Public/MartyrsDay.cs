using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Gabon.Public
{
    /// <summary>
    /// Martyr's Day
    /// </summary>
    public class MartyrsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Gabon;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Gabon;

        /// <inheritdoc />
        public override string Name { get; } = "Martyr's Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 6;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ga_martyrs_day";
    }
}