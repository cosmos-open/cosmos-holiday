using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Globalization;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Brunei.Religion
{
    /// <summary>
    /// First Day of Ramadan<br />
    /// ms: Hari Pertama Berpuasa
    /// </summary>
    public class FirstDayOfRamadan: IslamicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Brunei;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Brunei;

        /// <inheritdoc />
        public override string Name { get; } = "Hari Pertama Berpuasa";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override IslamicMonths IslamicMonth { get; set; } = IslamicMonths.Ramadan;

        /// <inheritdoc />
        protected override int IslamicDay { get; set; } = 1;
        
        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bn_first_day_of_ramadan";
    }
}