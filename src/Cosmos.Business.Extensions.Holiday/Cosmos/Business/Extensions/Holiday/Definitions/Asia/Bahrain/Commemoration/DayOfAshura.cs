using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Globalization;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Bahrain.Commemoration
{
    /// <summary>
    /// Day of Ashura
    /// <br />
    /// ar: عاشوراء
    /// </summary>
    public class DayOfAshura : IslamicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bahrain;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Bahrain;

        /// <inheritdoc />
        public override string Name { get; } = "عاشوراء";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        protected override IslamicMonths IslamicMonth { get; set; } = IslamicMonths.Muharram;

        /// <inheritdoc />
        protected override int IslamicDay { get; set; } = 10;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bh_ashura";
    }
}