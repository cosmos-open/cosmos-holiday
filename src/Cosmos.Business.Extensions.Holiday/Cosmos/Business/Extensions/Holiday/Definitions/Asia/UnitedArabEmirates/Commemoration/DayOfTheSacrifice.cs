using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Globalization;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.UnitedArabEmirates.Commemoration
{
    /// <summary>
    /// Day of the Sacrifice
    /// </summary>
    public class DayOfTheSacrifice : IslamicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.UnitedArabEmirates;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.UnitedArabEmirates;

        /// <inheritdoc />
        public override string Name { get; } = "عيد الأضحى";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        protected override (IslamicMonths Month, int Day)? FromIslamicDate { get; set; } = (IslamicMonths.DulHijjah, 10);

        /// <inheritdoc />
        protected override (IslamicMonths Month, int Day)? ToIslamicDate { get; set; } = (IslamicMonths.DulHijjah, 12);

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ae_sacrifice";
    }
}