using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Globalization;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Brunei.Commemoration
{
    /// <summary>
    /// Nuzul Al-Quran<br />
    /// ms: Hari Nuzul Al-Quran
    /// </summary>
    public class NuzulAlQuran : IslamicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Brunei;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Brunei;

        /// <inheritdoc />
        public override string Name { get; } = "Hari Nuzul Al-Quran";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        protected override IslamicMonths IslamicMonth { get; set; } = IslamicMonths.Ramadan;

        /// <inheritdoc />
        protected override int IslamicDay { get; set; } = 17;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bn_nuzul_al_quran";
    }
}