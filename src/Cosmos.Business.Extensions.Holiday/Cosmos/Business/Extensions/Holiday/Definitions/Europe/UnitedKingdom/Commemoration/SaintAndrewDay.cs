using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.UnitedKingdom.Commemoration
{
    /// <summary>
    /// Saint Andrew's Day
    /// </summary>
    public class SaintAndrewDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.UnitedKingdom;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.UnitedKingdom;

        /// <inheritdoc />
        public override string RegionCode { get; } = "GB-SCT";

        /// <summary>
        /// Battle of the Boyne
        /// </summary>
        public override string Name { get; } = "Saint Andrew's Day";

        /// <summary>
        /// Type of holiday
        /// </summary>
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 30;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gb_andrew";
    }
}