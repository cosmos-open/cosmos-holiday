using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Globalization;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Kenya.Religion
{
    /// <summary>
    /// End of Ramadan<br />
    /// sw: Idd-ul-Fitr
    /// </summary>
    public class EndOfRamadan : IslamicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Kenya;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Kenya;

        /// <inheritdoc />
        public override string Name { get; } = "Idd-ul-Fitr";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override IslamicMonths IslamicMonth { get; set; } = IslamicMonths.Shawwal;

        /// <inheritdoc />
        protected override int IslamicDay { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ke_end_of_ramadan";
    }
}