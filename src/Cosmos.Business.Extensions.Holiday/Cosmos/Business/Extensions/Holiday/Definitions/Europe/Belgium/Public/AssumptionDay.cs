using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Belgium.Public
{
    /// <summary>
    /// Assumption Day
    /// </summary>
    public class AssumptionDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Belgium;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Belgium;

        /// <inheritdoc />
        public override string Name { get; } = "Onze Lieve Vrouw hemelvaart";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 8;

        /// <inheritdoc />
        public override int Day { get; set; } = 15;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_be_assumption_day";
    }
}