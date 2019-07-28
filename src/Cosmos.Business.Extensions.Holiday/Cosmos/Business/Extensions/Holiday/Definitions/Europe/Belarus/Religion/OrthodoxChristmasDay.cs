using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Belarus.Religion
{
    /// <summary>
    /// Orthodox Christmas Day
    /// </summary>
    public class OrthodoxChristmasDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Belarus;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Belarus;

        /// <inheritdoc />
        public override string Name { get; } = "Каляды праваслаўныя";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 7;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_by_orthodox_christmas";
    }
}