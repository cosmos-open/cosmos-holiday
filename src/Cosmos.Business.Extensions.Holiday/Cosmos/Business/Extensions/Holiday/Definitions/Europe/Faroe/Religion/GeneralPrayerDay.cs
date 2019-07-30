using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Faroe.Religion
{
    /// <summary>
    /// General Prayer Day
    /// </summary>
    public class GeneralPrayerDay : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Faroe;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Faroe;

        /// <inheritdoc />
        public override string Name { get; } = "Store bededag";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 5 + 3 * 7;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_fo_general_prayer";
    }
}