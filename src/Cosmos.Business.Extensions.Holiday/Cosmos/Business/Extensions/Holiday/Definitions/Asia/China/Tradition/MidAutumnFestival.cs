using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Tradition
{
    /// <summary>
    /// 中秋节 Mid-Autumn Festival
    /// </summary>
    public class MidAutumnFestival : ChineseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.China;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.China;

        /// <inheritdoc />
        public override string Name { get; } = "中秋节";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        /// <inheritdoc />
        protected override int ChineseMonth { get; } = 8;

        /// <inheritdoc />
        protected override int ChineseDay { get; } = 15;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_815";
    }
}