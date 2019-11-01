using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Globalization;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Montenegro.Religion
{
    /// <summary>
    /// First Day of Ramadan<br />
    /// ms: Hari Pertama Berpuasa
    /// </summary>
    public class FirstDayOfRamadan: IslamicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Montenegro;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Montenegro;

        /// <inheritdoc />
        public override string Name { get; } = "First day of Ramadan";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override IslamicMonths IslamicMonth { get; set; } = IslamicMonths.Ramadan;

        /// <inheritdoc />
        protected override int IslamicDay { get; set; } = 1;
        
        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_me_first_day_of_ramadan";
    }
}