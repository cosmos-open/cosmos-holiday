using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Peru.Commemoration
{
    /// <summary>
    /// Battle of Angamos
    /// </summary>
    public class BattleOfAngamos : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Peru;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Peru;

        /// <inheritdoc />
        public override string Name { get; } = "Combate de Angamos";

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 8;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_py_angamos_battle";
    }
}