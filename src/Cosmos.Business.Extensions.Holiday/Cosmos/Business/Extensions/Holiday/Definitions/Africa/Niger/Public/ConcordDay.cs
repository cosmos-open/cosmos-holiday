using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Niger.Public
{
    /// <summary>
    /// Concord Day
    /// </summary>
    public class ConcordDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Niger;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Niger;

        /// <inheritdoc />
        public override string Name { get; } = "Concord Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 4;

        /// <inheritdoc />
        public override int Day { get; set; } = 24;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ne_concord";
    }
}