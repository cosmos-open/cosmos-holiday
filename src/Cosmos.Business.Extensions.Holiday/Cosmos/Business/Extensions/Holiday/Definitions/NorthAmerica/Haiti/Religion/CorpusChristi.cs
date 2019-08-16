using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Haiti.Religion
{
    /// <summary>
    /// Corpus Christi
    /// </summary>
    public class CorpusChristi : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Haiti;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Haiti;

        /// <inheritdoc />
        public override string Name { get; } = "Corpus Christi";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 4 + 7 * 8;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ht_corpus_christi";
    }
}