using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Latvia.Public
{
    /// <summary>
    /// New Year's Eve
    /// </summary>
    public class NewYearsEve : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Latvia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Latvia;

        /// <inheritdoc />
        public override string Name { get; } = "Vecgada vakars";

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 31;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_lv_new_year_eve";
    }
}