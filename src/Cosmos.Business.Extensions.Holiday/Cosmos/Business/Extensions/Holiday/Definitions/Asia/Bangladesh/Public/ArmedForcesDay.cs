using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Bangladesh.Public
{
    /// <summary>
    /// Armed Forces Day
    /// </summary>
    public class ArmyForcesDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bangladesh;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Bangladesh;

        /// <inheritdoc />
        public override string Name { get; } = "Armed Forces Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 21;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bd_army";
    }
}