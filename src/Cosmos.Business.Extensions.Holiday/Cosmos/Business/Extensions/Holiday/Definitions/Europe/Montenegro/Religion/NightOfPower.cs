using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Globalization;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Montenegro.Religion
{
    /// <summary>
    /// Night of Power<br />
    /// Laylat al-Qadr
    /// </summary>
    public class NightOfPower : IslamicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Montenegro;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Montenegro;

        /// <inheritdoc />
        public override string Name { get; } = "Laylat al-Qadr";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override IslamicMonths IslamicMonth { get; set; } = IslamicMonths.Ramadan;

        /// <inheritdoc />
        protected override int IslamicDay { get; set; } = 27;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_me_night_of_power";
    }
}