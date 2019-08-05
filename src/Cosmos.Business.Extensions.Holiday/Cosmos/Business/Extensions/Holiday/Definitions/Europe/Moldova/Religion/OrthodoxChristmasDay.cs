using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Moldova.Religion
{
    /// <summary>
    /// Orthodox Christmas Day
    /// </summary>
    public class OrthodoxChristmasDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Moldova;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Moldova;

        /// <inheritdoc />
        public override string Name { get; } = "Craciun pe stil Vechi (Orthodox Christmas)";

        /// <inheritdoc />
        public override (int Month, int Day)? FromDate { get; set; } = (1, 7);

        /// <inheritdoc />
        public override (int Month, int Day)? ToDate { get; set; } = (1, 8);

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_md_orthodox_christmas";
    }
}