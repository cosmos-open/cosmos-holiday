using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Kazakhstan.Commemoration
{
    /// <summary>
    /// First president day - December 1th
    /// </summary>
    public class FirstPresidentDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Kazakhstan;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Kazakhstan;

        /// <inheritdoc />
        public override string Name { get; } = "День Первого Президента";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_kz_1st_president_day";
    }
}