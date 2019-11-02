using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Globalization;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.ChristmasIsland.Commemoration
{
    /// <summary>
    /// Day of the Sacrifice
    /// </summary>
    public class DayOfTheSacrifice : IslamicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.ChristmasIsland;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Australia;

        /// <inheritdoc />
        public override string Name { get; } = "Hari Raya Haji";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        protected override IslamicMonths IslamicMonth { get; set; } = IslamicMonths.DulHijjah;

        /// <inheritdoc />
        protected override int IslamicDay { get; set; } = 10;
        
        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cx_sacrifice";
    }
}