using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Kazakhstan.Religion
{
    /// <summary>
    /// Christmas
    /// </summary>
    public class Christmas : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Kazakhstan;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Kazakhstan;

        /// <inheritdoc />
        public override string Name { get; } = "Рождество Христово";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 7;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_kz_christmas";
    }
}