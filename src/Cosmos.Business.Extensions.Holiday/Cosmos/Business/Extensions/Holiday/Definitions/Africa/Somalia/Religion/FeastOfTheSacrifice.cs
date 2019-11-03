using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Globalization;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Somalia.Religion
{
    /// <summary>
    /// Feast of the Sacrifice<br />
    /// fr: Fête du mouton
    /// </summary>
    public class FeastOfTheSacrifice : IslamicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Somalia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Somalia;

        /// <inheritdoc />
        public override string Name { get; } = "Feast of the Sacrifice (Eid al-Adha)";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override IslamicMonths IslamicMonth { get; set; } = IslamicMonths.DulHijjah;

        /// <inheritdoc />
        protected override int IslamicDay { get; set; } = 10;
        
        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_so_feast_of_the_sacrifice";
    }
}