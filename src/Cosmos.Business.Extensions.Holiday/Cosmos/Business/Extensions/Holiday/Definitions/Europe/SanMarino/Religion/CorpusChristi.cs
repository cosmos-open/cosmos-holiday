using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.SanMarino.Religion
{
    /// <summary>
    /// Corpus Christi
    /// </summary>
    public class CorpusChristi : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.SanMarino;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.SanMarino;

        /// <inheritdoc />
        public override string Name { get; } = "Corpus Christi";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 4 + 7 * 8;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_sm_corpus_christi";
    }
}