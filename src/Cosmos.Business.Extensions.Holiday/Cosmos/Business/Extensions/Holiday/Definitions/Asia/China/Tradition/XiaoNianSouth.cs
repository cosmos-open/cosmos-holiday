using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Tradition
{
    /// <summary>
    /// 南方小年
    /// </summary>
    public class XiaoNianSouth : ChineseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.China;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.China;

        /// <inheritdoc />
        public override string Name { get; } = "南方小年(掸尘)";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        /// <inheritdoc />
        protected override int ChineseMonth { get; } = 12;

        /// <inheritdoc />
        protected override int ChineseDay { get; } = 24;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_xiaonian_nan";
    }
}