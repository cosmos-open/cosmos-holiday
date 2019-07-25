using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Tradition
{
    /// <summary>
    /// 北方小年
    /// </summary>
    public class XiaoNianNorth: ChineseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.China;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.China;

        /// <inheritdoc />
        public override string Name { get; } = "北方小年(扫房)";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        /// <inheritdoc />
        protected override int ChineseMonth { get; } = 12;

        /// <inheritdoc />
        protected override int ChineseDay { get; } = 23;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_xiaonian_bei";
    }
}