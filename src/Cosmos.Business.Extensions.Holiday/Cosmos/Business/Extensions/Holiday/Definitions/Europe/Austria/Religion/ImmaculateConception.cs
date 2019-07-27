using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Austria.Religion
{
    /// <summary>
    /// ImmaculateConception
    /// </summary>
    public class ImmaculateConception : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Austria;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Austria;

        /// <inheritdoc />
        public override string Name { get; } = "Mariä Empfängnis";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_at_immaculate_conception";
    }
}