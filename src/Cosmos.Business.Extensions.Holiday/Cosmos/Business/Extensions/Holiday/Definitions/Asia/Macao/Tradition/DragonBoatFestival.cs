using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

/*
 * Macao, a part of China
 * 澳门，中华人民共和国的一部分
 */

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Macao.Tradition
{
    /// <summary>
    /// 端午节 Dragon Boat Festival
    /// </summary>
    public class DragonBoatFestival : ChineseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Macao;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.China;

        /// <inheritdoc />
        public override string Name { get; } = "端午節";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        /// <inheritdoc />
        protected override int ChineseMonth { get; } = 5;

        /// <inheritdoc />
        protected override int ChineseDay { get; } = 5;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_mo_55";
    }
}