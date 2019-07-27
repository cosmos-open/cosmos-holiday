using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.SouthAfrica.Tradition
{
    /// <summary>
    /// Heritage Day
    /// </summary>
    public class HeritageDay: BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.SouthAfrica;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.SouthAfrica;

        /// <inheritdoc />
        public override string Name { get; } = "Heritage Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        /// <inheritdoc />
        public override int Month { get; set; } = 9;

        /// <inheritdoc />
        public override int Day { get; set; } = 24;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_za_heritage";

        /// <inheritdoc />
        public override int? Since { get; } = 1995;
    }
}