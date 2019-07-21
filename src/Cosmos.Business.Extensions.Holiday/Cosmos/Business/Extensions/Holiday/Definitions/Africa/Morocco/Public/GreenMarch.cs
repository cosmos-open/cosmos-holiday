using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Morocco.Public
{
    /// <summary>
    /// Green March
    /// </summary>
    public class GreenMarch : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Morocco;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Morocco;

        /// <inheritdoc />
        public override string Name { get; } = "Eid Al Massira Al Khadra";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 6;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ma_green_march";
    }
}