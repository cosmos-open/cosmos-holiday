using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Tradition
{
    /// <summary>
    /// 元宵节
    /// </summary>
    public class LanternFestival : ChineseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.China;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// Lantern Festival
        /// </summary>
        public override string Name { get; } = "元宵节";

        /// <summary>
        /// Type of holiday
        /// </summary>
        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        /// <inheritdoc />
        protected override int ChineseMonth { get; } = 1;

        /// <inheritdoc />
        protected override int ChineseDay { get; } = 15;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_shangyuan";
    }
}