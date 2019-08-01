using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Latvia.Public
{
    /// <summary>
    /// Midsummer Eve
    /// </summary>
    public class MidsummerEve : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Latvia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Latvia;

        /// <inheritdoc />
        public override string Name { get; } = "Līgo Diena";

        /// <inheritdoc />
        public override int Month { get; set; } = 6;

        /// <inheritdoc />
        public override int Day { get; set; } = 23;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_lv_midsummer_eve";
    }
}