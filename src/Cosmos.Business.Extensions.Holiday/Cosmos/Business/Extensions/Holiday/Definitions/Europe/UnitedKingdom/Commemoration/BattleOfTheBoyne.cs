using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.UnitedKingdom.Commemoration
{
    /// <summary>
    /// Battle of the Boyne
    /// </summary>
    public class BattleOfTheBoyne : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.UnitedKingdom;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.UnitedKingdom;

        /// <inheritdoc />
        public override string RegionCode { get; } = "GB-NIR";

        /// <inheritdoc />
        public override string Name { get; } = "Battle of the Boyne";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 7;

        /// <inheritdoc />
        public override int Day { get; set; } = 12;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gb_battle_boyne";
    }
}