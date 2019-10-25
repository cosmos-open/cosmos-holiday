using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Cameroun.Religion
{
    /// <summary>
    /// Good Friday<br />
    /// fr: Vendredi saint
    /// </summary>
    public class GoodFriday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Cameroun;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Cameroun;

        /// <inheritdoc />
        public override string Name { get; } = "Vendredi saint";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cm_good_friday";
    }
}