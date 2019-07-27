using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Spain.Religion
{
    /// <summary>
    /// St. John's Day
    /// </summary>
    public class StJoansDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Spain;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Spain;

        /// <inheritdoc />
        public override string RegionCode { get; } = "ES-CT";

        /// <inheritdoc />
        public override string Name { get; } = "Saint Joan's Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 6;

        /// <inheritdoc />
        public override int Day { get; set; } = 24;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_es_joan";
    }
}