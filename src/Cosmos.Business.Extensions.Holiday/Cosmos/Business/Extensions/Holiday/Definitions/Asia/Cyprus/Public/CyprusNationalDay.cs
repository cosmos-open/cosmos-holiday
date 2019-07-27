using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Cyprus.Public
{
    /// <summary>
    /// Cyprus National Day
    /// </summary>
    public class CyprusNationalDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Cyprus;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Cyprus;

        /// <inheritdoc />
        public override string Name { get; } = "Cyprus National Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 4;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cy_cyprus_national";
    }
}