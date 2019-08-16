using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Poland.Public
{
    /// <summary>
    /// Independence Day
    /// </summary>
    public class IndependenceDay2018 : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Poland;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Poland;

        /// <inheritdoc />
        public override string Name { get; } = "Narodowe Święto Niepodległości";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 12;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_pl_independence_100y";

        /// <inheritdoc />
        public override int? Since { get; } = 2018;

        /// <inheritdoc />
        public override int? End { get; } = 2018;
    }
}