using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Austria.Public
{
    /// <summary>
    /// Staatsfeiertag / National Holiday
    /// </summary>
    public class NationalHoliday : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Austria;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Austria;

        /// <summary>
        /// Staatsfeiertag
        /// </summary>
        public override string Name { get; } = "Staatsfeiertag";

        /// <summary>
        /// Type of holiday
        /// </summary>
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_at_national";

        /// <inheritdoc />
        public override int? Since { get; } = 1955;
    }
}