using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Armenia.Public
{
    /// <summary>
    /// Army Day
    /// </summary>
    public class ArmyDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Armenia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Armenia;

        /// <inheritdoc />
        public override string Name { get; } = "Բանակի օր";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 28;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_am_army";
    }
}