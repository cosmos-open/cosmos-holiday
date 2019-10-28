using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Ethiopia.Public
{
    /// <summary>
    /// Derg Downfall Day<br />
    /// am: ደርግ የወደቀበት ቀን
    /// </summary>
    public class DergDownfallDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Ethiopia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Ethiopia;

        /// <inheritdoc />
        public override string Name { get; } = "ደርግ የወደቀበት ቀን";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 28;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_et_derg_downfall";
    }
}