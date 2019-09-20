using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Burundi.Religion
{
    /// <summary>
    /// Assumption Day<br />
    /// fr: Assomption
    /// </summary>
    public class AssumptionDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Burundi;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Burundi;

        /// <inheritdoc />
        public override string Name { get; } = "Assomption";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 8;

        /// <inheritdoc />
        public override int Day { get; set; } = 15;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bi_assumption_day";

        /// <inheritdoc />
        public override int? Since { get; } = 1568;
    }
}