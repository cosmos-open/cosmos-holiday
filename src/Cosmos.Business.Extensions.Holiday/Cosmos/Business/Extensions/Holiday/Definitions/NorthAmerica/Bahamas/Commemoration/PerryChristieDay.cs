using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Bahamas.Commemoration
{
    /// <summary>
    /// Perry Christie Day
    /// </summary>
    public class PerryChristieDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bahamas;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Bahamas;

        /// <inheritdoc />
        public override string Name { get; } = "PerryChristieDay";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 4;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bs_perry_christie";
    }
}