using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Serbia.Public
{
    /// <summary>
    /// Statehood Day
    /// </summary>
    public class StatehoodDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Serbia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Serbia;

        /// <inheritdoc />
        public override string Name { get; } = "Dan državnosti Srbije";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override (int Month, int Day)? FromDate { get; set; } = (2, 15);

        /// <inheritdoc />
        public override (int Month, int Day)? ToDate { get; set; } = (2, 16);

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_rs_statehood";
    }
}