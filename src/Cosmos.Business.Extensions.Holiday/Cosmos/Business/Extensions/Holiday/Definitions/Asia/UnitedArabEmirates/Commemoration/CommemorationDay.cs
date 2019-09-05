using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.UnitedArabEmirates.Commemoration
{
    /// <summary>
    /// Commemoration Day
    /// </summary>
    public class CommemorationDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.UnitedArabEmirates;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.UnitedArabEmirates;

        /// <inheritdoc />
        public override string Name { get; } = "يوم الشهيد";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ae_commemoration";
    }
}