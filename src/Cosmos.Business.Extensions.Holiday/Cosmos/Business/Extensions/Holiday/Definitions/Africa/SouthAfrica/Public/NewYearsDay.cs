using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.SouthAfrica.Public
{
    /// <summary>
    /// New Year's Day
    /// </summary>
    public class NewYearsDay: BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.SouthAfrica;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.SouthAfrica;

        /// <inheritdoc />
        public override string Name { get; } = "New Year's Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_za_new_year";

        /// <inheritdoc />
        public override int? Since { get; } = 1910;
    }
}