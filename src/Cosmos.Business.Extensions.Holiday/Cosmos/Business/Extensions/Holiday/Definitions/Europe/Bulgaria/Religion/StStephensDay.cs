using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Bulgaria.Religion
{
    /// <summary>
    /// St. Stephen's Day
    /// </summary>
    public class StStephensDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bulgaria;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Bulgaria;

        /// <inheritdoc />
        public override string Name { get; } = "Рождество Христово";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 26;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bg_stephen";
    }
}