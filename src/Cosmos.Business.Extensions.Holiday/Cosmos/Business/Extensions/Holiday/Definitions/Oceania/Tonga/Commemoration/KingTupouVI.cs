using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Oceania.Tonga.Commemoration
{
    /// <summary>
    /// Official Birthday of His Majesty King Tupou VI
    /// </summary>
    public class KingTupouVI : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Tonga;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Tonga;

        /// <inheritdoc />
        public override string Name { get; } = "Anzac Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 7;

        /// <inheritdoc />
        public override int Day { get; set; } = 4;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_to_king_tupou_vi";
    }
}