using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Guatemala.Public
{
    /// <summary>
    /// Revolution Day
    /// </summary>
    public class RevolutionDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Guatemala;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Guatemala;

        /// <inheritdoc />
        public override string Name { get; } = "Revolution Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 20;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gt_revolution";
    }
}