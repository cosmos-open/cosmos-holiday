using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Malta.Religion
{
    /// <summary>
    /// Christmas Day
    /// </summary>
    public class ChristmasDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Malta;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Malta;

        /// <inheritdoc />
        public override string Name { get; } = "Il-Milied​";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 25;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_mt_christmas";
    }
}