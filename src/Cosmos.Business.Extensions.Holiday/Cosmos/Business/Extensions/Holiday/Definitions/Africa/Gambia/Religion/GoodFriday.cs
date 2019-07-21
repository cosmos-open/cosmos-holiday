using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Gambia.Religion
{
    /// <summary>
    /// Good Friday
    /// </summary>
    public class GoodFriday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Gambia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Gambia;

        /// <inheritdoc />
        public override string Name { get; } = "Good Friday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gm_good_friday";
    }
}