using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Globalization;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Montenegro.Religion
{
    /// <summary>
    /// Bara'at Night<br />
    /// en: Laylat al-Bara'at
    /// </summary>
    public class BaraAtNight: IslamicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Montenegro;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Montenegro;

        /// <inheritdoc />
        public override string Name { get; } = "Laylat al-Bara'at";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override IslamicMonths IslamicMonth { get; set; } = IslamicMonths.Shaban;

        /// <inheritdoc />
        protected override int IslamicDay { get; set; } = 15;
        
        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_me_bara_at_night";
    }
}