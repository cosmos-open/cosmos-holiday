using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Malta.Public
{
    /// <summary>
    /// Worker's Day
    /// </summary>
    public class WorkersDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Malta;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Malta;

        /// <inheritdoc />
        public override string Name { get; } = "Jum il-Ħaddiem";

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_mt_workers";
    }
}