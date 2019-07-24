using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Suriname.Public
{
    /// <summary>
    /// Day of the Revolution
    /// </summary>
    public class DayOfTheRevolution : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Suriname;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Suriname;

        /// <inheritdoc />
        public override string Name { get; } = "Day of the Revolution";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 2;

        /// <inheritdoc />
        public override int Day { get; set; } = 23;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_sr_revolution";
    }
}