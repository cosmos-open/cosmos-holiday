using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Togo.Commemoration
{
    /// <summary>
    /// Day of the Martyrs
    /// </summary>
    public class Martyrs: BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Togo;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Togo;

        /// <inheritdoc />
        public override string Name { get; } = "Journée des Martyrs";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 6;

        /// <inheritdoc />
        public override int Day { get; set; } = 21;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_tg_independence";
    }
}