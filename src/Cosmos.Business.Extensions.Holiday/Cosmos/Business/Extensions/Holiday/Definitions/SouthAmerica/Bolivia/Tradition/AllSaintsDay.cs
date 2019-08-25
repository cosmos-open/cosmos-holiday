using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Bolivia.Tradition
{
    /// <summary>
    /// All Saints' Day
    /// </summary>
    public class AllSaintsDay: BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bolivia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Bolivia;

        /// <inheritdoc />
        public override string Name { get; } = "Todos Santos";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bo_all_saints_day";
    }
}