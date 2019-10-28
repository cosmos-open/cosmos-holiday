using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Ethiopia.Religion
{
    /// <summary>
    /// Epiphany<br />
    /// am: ብርሐነ ጥምቀት
    /// </summary>
    public class Epiphany : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Ethiopia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Ethiopia;

        /// <inheritdoc />
        public override string Name { get; } = "ብርሐነ ጥምቀት";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 19;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_et_epiphany";
    }
}