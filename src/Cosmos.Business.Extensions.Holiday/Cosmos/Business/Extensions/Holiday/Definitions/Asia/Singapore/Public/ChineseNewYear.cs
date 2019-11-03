using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Singapore.Public
{
    /// <summary>
    /// 春节 Chinese New Year / Spring Festival<br />
    /// ms: Tahun Baru Cina
    /// fil: Bagong Taon ng mga Tsino
    /// </summary>
    public class ChineseNewYear : ChineseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Singapore;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Singapore;

        /// <inheritdoc />
        public override string Name { get; } = "Chinese New Year";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        protected override int ChineseMonth { get; } = 1;

        /// <inheritdoc />
        protected override int ChineseDay { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_sg_chinese_new_year";
    }
}