using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Guatemala.Public
{
    /// <summary>
    /// Army Day
    /// </summary>
    public class ArmyDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Guatemala;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Guatemala;

        /// <inheritdoc />
        public override string Name { get; } = "Army Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 6;

        /// <inheritdoc />
        public override int Day { get; set; } = 30;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gt_army";
    }
}