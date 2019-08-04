using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Macedonia.Public
{
    /// <summary>
    /// Day of the Macedonian Revolutionary Struggle
    /// </summary>
    public class RevolutionaryStruggle : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Macedonia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Macedonia;

        /// <inheritdoc />
        public override string Name { get; } = "Ден на македонската револуционерна борба,Den na makedonskata revolucionarna borba";

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 23;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_mk_revolutionary_struggle";
    }
}