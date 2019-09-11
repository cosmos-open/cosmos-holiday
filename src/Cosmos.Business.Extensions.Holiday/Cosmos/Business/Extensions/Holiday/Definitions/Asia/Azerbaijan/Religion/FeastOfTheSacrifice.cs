using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Globalization;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Azerbaijan.Religion
{
    /// <summary>
    /// Feast of the Sacrifice
    /// </summary>
    public class FeastOfTheSacrifice : IslamicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Azerbaijan;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Azerbaijan;

        /// <inheritdoc />
        public override string Name { get; } = "Qurban Bayramı";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override (IslamicMonths Month, int Day)? FromIslamicDate { get; set; } = (IslamicMonths.DulHijjah, 10);

        /// <inheritdoc />
        protected override (IslamicMonths Month, int Day)? ToIslamicDate { get; set; } = (IslamicMonths.DulHijjah, 11);

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_az_feast_of_the_sacrifice";
    }
}