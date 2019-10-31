using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Globalization;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Kenya.Religion
{
    /// <summary>
    /// Feast of the Sacrifice<br />
    /// sw: Idd-ul-Azha
    /// </summary>
    public class FeastOfTheSacrifice : IslamicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Kenya;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Kenya;

        /// <inheritdoc />
        public override string Name { get; } = "Idd-ul-Azha";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override IslamicMonths IslamicMonth { get; set; } = IslamicMonths.DulHijjah;

        /// <inheritdoc />
        protected override int IslamicDay { get; set; } = 10;
        
        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ke_feast_of_the_sacrifice";
    }
}