using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Austria.Public
{
    /// <summary>
    /// Assumption Day
    /// </summary>
    public class AssumptionDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Austria;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Austria;

        /// <summary>
        /// Maria Himmelfahrt
        /// </summary>
        public override string Name { get; } = "Maria Himmelfahrt";

        /// <summary>
        /// Type of holiday
        /// </summary>
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 8;

        /// <inheritdoc />
        public override int Day { get; set; } = 15;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_at_assumptionday";
    }
}