using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Ethiopia.Public
{
    /// <summary>
    /// Day of Lament<br />
    /// am:የቀይ ሽብር መታሰቢያ ቀን
    /// </summary>
    public class DayOfLament : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Ethiopia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Ethiopia;

        /// <inheritdoc />
        public override string Name { get; } = "የቀይ ሽብር መታሰቢያ ቀን";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 28;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_et_lament";
    }
}