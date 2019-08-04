using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Nicaragua.Commemoration
{
    /// <summary>
    /// Battle of San Jacinto
    /// </summary>
    public class BattleOfSanJacinto : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Nicaragua;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Nicaragua;

        /// <inheritdoc />
        public override string Name { get; } = "Battle of San Jacinto";

        /// <inheritdoc />
        public override int Month { get; set; } = 9;

        /// <inheritdoc />
        public override int Day { get; set; } = 14;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ni_battle_of_san_jacinto";
    }
}