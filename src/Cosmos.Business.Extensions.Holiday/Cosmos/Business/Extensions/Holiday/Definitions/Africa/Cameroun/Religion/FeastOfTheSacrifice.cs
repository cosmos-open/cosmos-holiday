using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Globalization;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Cameroun.Religion
{
    /// <summary>
    /// Feast of the Sacrifice<br />
    /// fr: Fête du mouton
    /// </summary>
    public class FeastOfTheSacrifice : IslamicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Cameroun;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Cameroun;

        /// <inheritdoc />
        public override string Name { get; } = "Fête du mouton";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override IslamicMonths IslamicMonth { get; set; } = IslamicMonths.DulHijjah;

        /// <inheritdoc />
        protected override int IslamicDay { get; set; } = 10;
        
        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cm_feast_of_the_sacrifice";
    }
}