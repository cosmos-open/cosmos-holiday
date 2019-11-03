using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Singapore.Public
{
    /// <summary>
    /// National Day
    /// </summary>
    public class NationalDay: BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Singapore;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Singapore;

        /// <inheritdoc />
        public override string Name { get; } = "National Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 8;

        /// <inheritdoc />
        public override int Day { get; set; } = 9;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_sg_national";
    }
}