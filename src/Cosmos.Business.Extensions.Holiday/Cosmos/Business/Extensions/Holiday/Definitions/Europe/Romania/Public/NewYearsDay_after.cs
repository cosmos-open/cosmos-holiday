using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Romania.Public
{
    /// <summary>
    /// Day after New Year's Day
    /// </summary>
    public class NewYearsDayAfter : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Romania;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Romania;

        /// <inheritdoc />
        public override string Name { get; } = "Anul Nou";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ro_new_year_after";
    }
}