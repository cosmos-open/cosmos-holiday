using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Slovenia.Public
{
    /// <summary>
    /// Day of Uprising Against Occupation
    /// </summary>
    public class DayOfUprisingAgainstOccupation : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Slovenia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Slovenia;

        /// <inheritdoc />
        public override string Name { get; } = "dan upora proti okupatorju";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 4;

        /// <inheritdoc />
        public override int Day { get; set; } = 27;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_si_uprising_against_occupation";
    }
}