using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Globalization;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Somalia.Commemoration
{
    /// <summary>
    /// Day of Ashura
    /// </summary>
    public class DayOfAshura : IslamicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Somalia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Somalia;

        /// <inheritdoc />
        public override string Name { get; } = "Day of Ashura";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        protected override IslamicMonths IslamicMonth { get; set; } = IslamicMonths.Muharram;

        /// <inheritdoc />
        protected override int IslamicDay { get; set; } = 10;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_so_ashura";
    }
}