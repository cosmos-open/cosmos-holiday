using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Albania.Public
{
    /// <summary>
    /// New Year's Day
    /// </summary>
    public class NewYearsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Albania;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Albania;

        /// <inheritdoc />
        public override string Name { get; } = "Viti i Ri";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override (int Month, int Day)? FromDate { get; set; } = (1, 1);

        /// <inheritdoc />
        public override (int Month, int Day)? ToDate { get; set; } = (1, 2);

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_al_new_years_day";
    }
}