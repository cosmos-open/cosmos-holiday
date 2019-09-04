using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Zimbabwe.Public
{
    /// <summary>
    /// Robert Mugabe National Youth Day
    /// </summary>
    public class YouthDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Zimbabwe;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Zimbabwe;

        /// <inheritdoc />
        public override string Name { get; } = "Robert Mugabe National Youth Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 2;

        /// <inheritdoc />
        public override int Day { get; set; } = 21;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_zw_youth";
    }
}