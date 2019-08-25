using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Bolivia.Religion
{
    /// <summary>
    /// Corpus Christi
    /// </summary>
    public class CorpusChristi : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bolivia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Bolivia;

        /// <inheritdoc />
        public override string Name { get; } = "Corpus Christi";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 4 + 7 * 8;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bo_corpus_christi";
    }
}