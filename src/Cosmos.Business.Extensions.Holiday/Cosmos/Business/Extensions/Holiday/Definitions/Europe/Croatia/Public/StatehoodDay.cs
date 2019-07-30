using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Croatia.Public
{
    /// <summary>
    /// Statehood Day
    /// </summary>
    public class StatehoodDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Croatia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Croatia;

        /// <inheritdoc />
        public override string Name { get; } = "Dan državnosti";

        /// <inheritdoc />
        public override int Month { get; set; } = 6;

        /// <inheritdoc />
        public override int Day { get; set; } = 25;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_hr_statehood";
    }
}