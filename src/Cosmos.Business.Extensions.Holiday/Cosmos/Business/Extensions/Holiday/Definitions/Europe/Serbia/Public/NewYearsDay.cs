using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Serbia.Public
{
    /// <summary>
    /// New Year's Day January 1
    /// </summary>
    public class NewYearsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Serbia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Serbia;

        /// <inheritdoc />
        public override string Name { get; } = "Nova Godina";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override (int Month, int Day)? FromDate { get; set; } = (1, 1);

        /// <inheritdoc />
        public override (int Month, int Day)? ToDate { get; set; } = (1, 2);

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_rs_new_year";
    }
}