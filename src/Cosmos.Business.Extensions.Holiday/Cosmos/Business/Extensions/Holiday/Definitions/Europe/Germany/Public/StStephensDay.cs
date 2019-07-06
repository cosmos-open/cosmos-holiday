using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Germany.Public
{
    /// <summary>
    /// St. Stephen's Day
    /// </summary>
    public class StStephensDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Germany;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Germany;

        /// <inheritdoc />
        public override string Name { get; } = "Zweiter Weihnachtstag";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 26;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_de_ststephens_day";
    }
}