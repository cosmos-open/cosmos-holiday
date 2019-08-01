using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Italy.Public
{
    /// <summary>
    /// Republic Day
    /// </summary>
    public class RepublicDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Italy;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Italy;

        /// <inheritdoc />
        public override string Name { get; } = "Festa della Repubblica";

        /// <inheritdoc />
        public override int Month { get; set; } = 6;

        /// <inheritdoc />
        public override int Day { get; set; } = 2;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_it_republic";
    }
}