using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Egypt.Public
{
    /// <summary>
    /// Sinai Liberation Day
    /// </summary>
    public class SinaiLiberationDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Egypt;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Egypt;

        /// <summary>
        /// April Fool's Day
        /// </summary>
        public override string Name { get; } = "عيد تحرير سيناء";

        /// <summary>
        /// Type of holiday
        /// </summary>
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <summary>
        /// Month
        /// </summary>
        public override int Month { get; set; } = 4;

        /// <summary>
        /// Day
        /// </summary>
        public override int Day { get; set; } = 25;

        /// <summary>
        /// i18n
        /// </summary>
        public override string I18NIdentityCode { get; } = "i18n_holiday_eg_sinai_liberation_day";
    }
}