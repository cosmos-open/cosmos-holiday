using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Switzerland.Religion
{
    /// <summary>
    /// Corpus Christi
    /// </summary>
    public class CorpusChristi : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Switzerland;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Switzerland;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string>
        {
            "CH-LU", "CH-UR", "CH-SZ", "CH-OW", "CH-NW", "CH-ZG", "CH-FR", "CH-SO",
            "CH-BL", "CH-AI", "CH-GR", "CH-AG", "CH-TI", "CH-VS", "CH-NE", "CH-JU"
        };

        /// <inheritdoc />
        public override string Name { get; } = "Fronleichnam";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 4 + 7 * 8;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ch_corpus_christi";
    }
}