using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Namibia.Public
{
    /// <summary>
    /// Cassinga Day
    /// </summary>
    public class CassingaDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Namibia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Namibia;

        /// <inheritdoc />
        public override string Name { get; } = "Cassinga Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 4;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_na_cassinga_day";
    }
}