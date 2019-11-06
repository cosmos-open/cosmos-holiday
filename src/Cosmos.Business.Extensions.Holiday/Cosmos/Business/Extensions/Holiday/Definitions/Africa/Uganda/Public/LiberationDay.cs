using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Uganda.Public
{
    /// <summary>
    /// Liberation Day
    /// </summary>
    public class LiberationDay: BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Uganda;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Uganda;

        /// <inheritdoc />
        public override string Name { get; } = "Liberation Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 26;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ug_liberation";
    }
}